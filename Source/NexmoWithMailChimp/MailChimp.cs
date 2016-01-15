using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailChimp;
using MailChimp.Lists;
using MailChimp.Campaigns;
using MailChimp.Templates;
using MailChimp.Helper;
using CRMNexmo.Plugins;
using System.Xml;
using System.IO;
namespace NexmoWithMailChimp
{
    public partial class NexMO : Form
    {
        MailChimpManager mc = null;//new MailChimpManager("87bb5e71ad4907d0292a1c43edb0c886-us11");
        SmsSender SmsSender = new SmsSender();
        string nexmoAPI = string.Empty, nexmoSecretKey = string.Empty, nexmoFromNumber = string.Empty, nexmoMessage = string.Empty;
        string mailchimpAPI = string.Empty, mailchimptitle = string.Empty, mailchimpSubject = string.Empty, mailchimpFromName = string.Empty, mailchimpToName = string.Empty, mailchimpFromEmail = string.Empty;
        public NexMO()
        {
            InitializeComponent();
            ReadSettings();
            MailChimpLoad();
            //SmsSender.SendSMS("919461393297", "919460264151", "5b2a23d7", "59d9fa03", Uri.EscapeUriString("Test Message"));
        }

        public void ReadSettings()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("settings.xml");

                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/settings/nexmo");
                foreach (XmlNode node in nodeList)
                {
                    nexmoAPI = node.SelectSingleNode("api") != null ? node.SelectSingleNode("api").InnerText : "";
                    nexmoSecretKey = node.SelectSingleNode("secret-key") != null ? node.SelectSingleNode("secret-key").InnerText : "";
                    nexmoFromNumber = node.SelectSingleNode("from-number") != null ? node.SelectSingleNode("from-number").InnerText : "";
                    nexmoMessage = node.SelectSingleNode("message") != null ? node.SelectSingleNode("message").InnerText : "";
                }

                XmlNodeList mailchimpList = xmlDoc.DocumentElement.SelectNodes("/settings/mailchimp");
                foreach (XmlNode node in mailchimpList)
                {
                    mailchimpAPI = node.SelectSingleNode("api") != null ? node.SelectSingleNode("api").InnerText : "";
                    mailchimptitle = node.SelectSingleNode("title") != null ? node.SelectSingleNode("title").InnerText : "";
                    mailchimpSubject = node.SelectSingleNode("subject") != null ? node.SelectSingleNode("subject").InnerText : "";
                    mailchimpFromName = node.SelectSingleNode("from-name") != null ? node.SelectSingleNode("from-name").InnerText : "";
                    mailchimpToName = node.SelectSingleNode("to-name") != null ? node.SelectSingleNode("to-name").InnerText : "";
                    mailchimpFromEmail = node.SelectSingleNode("from-email") != null ? node.SelectSingleNode("from-email").InnerText : "";
                }

                if (string.IsNullOrEmpty(nexmoAPI)
                      || string.IsNullOrEmpty(nexmoSecretKey)
                      || string.IsNullOrEmpty(nexmoFromNumber)
                      || string.IsNullOrEmpty(nexmoMessage)
                      || string.IsNullOrEmpty(mailchimpAPI)
                      || string.IsNullOrEmpty(mailchimptitle)
                      || string.IsNullOrEmpty(mailchimpSubject)
                      || string.IsNullOrEmpty(mailchimpFromName)
                      || string.IsNullOrEmpty(mailchimpToName)
                      || string.IsNullOrEmpty(mailchimpFromEmail))
                {
                    OpenSettingsFrom();
                }
                else
                {
                    mc = new MailChimpManager(mailchimpAPI);
                }
            }
            catch (Exception ex)
            {
                OpenSettingsFrom();
            }
        }

        public void MailChimpLoad()
        {
            // CampaignListResult details = mc.GetCampaigns();
            //CampaignFilter options = new CampaignFilter();
            //options.CampaignId = "a5a9439561";
            //CampaignListResult ss = mc.GetCampaigns(options);


            //-- Template
            List<MailChimpList> mailChimpTemplate = new List<MailChimpList>();
            mailChimpTemplate.Add(new MailChimpList("0", "Select Template"));
            var types = new TemplateTypes()
            {
                User = true,

            };
            var filters = new TemplateFilters()
            {
                IncludeInactive = false,
                IncludeDragAndDrop = true
            };

            TemplateListResult details = mc.GetTemplates(types, filters);
            foreach (var list in details.UserTemplates)
            {
                mailChimpTemplate.Add(new MailChimpList(list.TemplateID.ToString(), list.Name));
            }
            if (mailChimpTemplate != null && mailChimpTemplate.Count > 0)
            {
                cmbTemplate.DisplayMember = "Name";
                cmbTemplate.ValueMember = "Id";
                cmbTemplate.DataSource = mailChimpTemplate;
            }


            // --- List---
            List<MailChimpList> mailChimpList = new List<MailChimpList>();
            ListResult lists = mc.GetLists();
            mailChimpList.Clear();
            mailChimpList.Add(new MailChimpList("0", "Select List"));
            foreach (var list in lists.Data)
            {
                mailChimpList.Add(new MailChimpList(list.Id.ToString(), list.Name));
            }
            if (mailChimpList != null && mailChimpList.Count > 0)
            {
                cmbList.DisplayMember = "Name";
                cmbList.ValueMember = "Id";
                cmbList.DataSource = mailChimpList;
            }
        }
        private void btnNextTemplate_Click(object sender, EventArgs e)
        {
            pnlMailChimp.Visible = true;
            pnlTemplate.Visible = false;
            if (chkEnableSMS.Checked)
            {
                btnCamaignSend.Text = "Next";
            }
            else
            {
                btnCamaignSend.Text = "SendCampaign";
            }

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettingsFrom();
        }
        public void OpenSettingsFrom()
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();
        }

        private void btnCamaignSend_Click(object sender, EventArgs e)
        {
            if (chkEnableSMS.Checked)
            {
                pnlNexmoMessage.Visible = true;
                pnlMailChimp.Visible = false;
            }
            else
            {
                SendCampaign();
            }
        }
        public void SendCampaign()
        {
            if ((cmbTemplate.SelectedIndex > 0 && cmbTemplate.SelectedItem != null) && (cmbList.SelectedIndex > 0 && cmbList.SelectedItem != null))
            {
                Int32 selectedTemplateId = Convert.ToInt32(cmbTemplate.SelectedValue);

                string selectedListId = cmbList.SelectedValue.ToString();
                //IEnumerable<string> listEnum = new string[] { selectedListId.ToString() };

                //--Create Campaign
                CampaignSegmentOptions segmentOptions = new CampaignSegmentOptions();
                segmentOptions.Match = "All";
                CampaignCreateOptions options = new CampaignCreateOptions();
                options.Title = mailchimptitle;
                options.ListId = selectedListId;
                options.ToName = mailchimpToName;
                options.FromEmail = mailchimpFromEmail;
                options.FromName = mailchimpFromName;
                options.Subject = mailchimpSubject;
                options.TemplateID = selectedTemplateId;
                CampaignCreateContent content = new CampaignCreateContent();
                Campaign result = mc.CreateCampaign("regular", options, content, null, null);


                //GetMemberInfo
                if (chkEnableSMS.Checked)
                {
                    List<EmailParameter> emails = new List<EmailParameter>();
                    MembersResult results = mc.GetAllMembersForList(selectedListId, "subscribed", 0, 100);
                    foreach (var i in results.Data)
                    {
                        foreach (var j in i.MemberMergeInfo)
                        {
                            if (j.Key.Trim() == "PHONE")
                            {
                                if (!string.IsNullOrEmpty(j.Value.ToString()))
                                {
                                    //  SmsSender.SendSMS(j.Value.ToString(), "919460264151", "5b2a23d7", "59d9fa03", Uri.EscapeUriString("Test Message"));
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Success");
            this.Close();
        }
    }
}
