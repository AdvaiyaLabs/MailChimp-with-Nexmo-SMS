using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailChimp;
using MailChimp.Lists;
using MailChimp.Campaigns;
using MailChimp.Templates;
using MailChimp.Helper;
using CRMNexmo.Plugins;
using System.Xml;
using MailChimp.Reports;
using System.Web;

namespace NexmoWithMailChimp
{
    public partial class MailChimpCampaign : Form
    {
        MailChimpManager Manager = null;
        SmsSender SmsSender = new SmsSender();
        string NexmoAPI = string.Empty, NexmoSecretKey = string.Empty, NexmoFromNumber = string.Empty;
        string MailchimpAPI = string.Empty;


        public MailChimpCampaign()
        {
            InitializeComponent();
            try
            {

                ReadSettings();
                if (Manager != null)
                {
                    LoadCampaign();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        /// <summary>
        /// Read settings.xml file. If settings.xml is blank open Settings form.
        /// </summary>
        public void ReadSettings()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("settings.xml");

                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/settings/nexmo");
                foreach (XmlNode node in nodeList)
                {
                    NexmoAPI = node.SelectSingleNode("api") != null ? node.SelectSingleNode("api").InnerText : "";
                    NexmoSecretKey = node.SelectSingleNode("secret-key") != null ? node.SelectSingleNode("secret-key").InnerText : "";
                    NexmoFromNumber = node.SelectSingleNode("from-number") != null ? node.SelectSingleNode("from-number").InnerText : "";
                }

                XmlNodeList mailchimpList = xmlDoc.DocumentElement.SelectNodes("/settings/mailchimp");
                foreach (XmlNode node in mailchimpList)
                {
                    MailchimpAPI = node.SelectSingleNode("api") != null ? node.SelectSingleNode("api").InnerText : "";
                }

                if (string.IsNullOrEmpty(NexmoAPI)
                      || string.IsNullOrEmpty(NexmoSecretKey)
                      || string.IsNullOrEmpty(NexmoFromNumber)
                      || string.IsNullOrEmpty(MailchimpAPI))
                {
                    OpenSettingsFrom();
                }
                else
                {
                    Manager = new MailChimpManager(MailchimpAPI);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OpenSettingsFrom();
            }

        }
        /// <summary>
        /// Display campaign panel if user enable nexmo sms and hide Campaign panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextCampaign_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidateFields())
                {
                    string campaignId = cmbCampaign.SelectedValue.ToString();

                    if (chkEnableSMS.Checked)
                    {
                        BindFields();
                        pnlNexmoMessage.Visible = true;
                        pnlCampaign.Visible = false;
                    }
                    else
                    {
                        SendCampaign();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }
        }
        /// <summary>
        /// Validate nexmo fields 
        /// </summary>
        /// <returns></returns>
        public bool ValidateFields()
        {
            if (cmbCampaign.SelectedIndex <= 0 || cmbCampaign.SelectedItem == null)
            {
                MessageBox.Show("Please select Campaign.", "Campaign", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCampaign.Focus();
                return false;
            }

            if (chkEnableSMS.Checked && pnlNexmoMessage.Visible)
            {
                if (cmbFieldPhone.SelectedIndex <= 0 || cmbFieldPhone.SelectedItem == null)
                {
                    MessageBox.Show("Please select recipient field.", "Recipient field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbFieldPhone.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtMessage.Text.Trim()))
                {
                    MessageBox.Show("Please enter Message.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMessage.Focus();
                    return false;
                }
            }
            else
            {
                if (cmbCampaign.SelectedIndex > 0)
                {
                    bool isFoundPhoneField = false;
                    string listId = string.Empty;
                    string campaignId = cmbCampaign.SelectedValue.ToString();
                    CampaignFilter options = new CampaignFilter();
                    options.CampaignId = campaignId;
                    CampaignListResult campaign = Manager.GetCampaigns(options);
                    foreach (var data in campaign.Data)
                    {
                        listId = data.ListId;
                        break;
                    }
                    IEnumerable<string> listEnum = new string[] { listId.ToString() };
                    MergeVarResult results = Manager.GetMergeVars(listEnum);
                    foreach (var list in results.Data)
                    {
                        foreach (var mergeVars in list.MergeVars)
                        {
                            if (mergeVars.FieldType == "phone")
                            {
                                isFoundPhoneField = true;
                            }
                        }
                        if (!isFoundPhoneField)
                        {
                            MessageBox.Show("No Phone type field available in " + list.Name + "list.", "Phone field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Bind Campaign in dropdown
        /// </summary>
        public void LoadCampaign()
        {

            try
            {
                List<MailChimpList> mailChimpList = new List<MailChimpList>();
                mailChimpList.Add(new MailChimpList("0", "Select Campaign"));
                bool flag = true;
                int count = 0;

                while (flag)
                {

                    CampaignFilter filter = new CampaignFilter();
                    filter.Status = "save";
                    CampaignListResult lists = Manager.GetCampaigns(filter, count, 100);
                    if (lists.Data.Count == 0)
                    {
                        flag = false;
                        break;
                    }
                    foreach (var list in lists.Data)
                    {
                        mailChimpList.Add(new MailChimpList(list.Id.ToString(), list.Title));
                    }
                    count++;
                }
                if (mailChimpList != null && mailChimpList.Count > 0)
                {
                    cmbCampaign.DisplayMember = "Name";
                    cmbCampaign.ValueMember = "Id";
                    cmbCampaign.DataSource = mailChimpList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Open Settings form
        /// </summary>
        public void OpenSettingsFrom()
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();

        }
        /// <summary>
        /// Filled value in title, subject,fromname, fromemail on campaign selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCampaign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampaign.SelectedIndex > 0 && cmbCampaign.SelectedItem != null)
            {
                string campaignId = cmbCampaign.SelectedValue.ToString();
                CampaignFilter options = new CampaignFilter();
                options.CampaignId = campaignId;
                CampaignListResult lists = Manager.GetCampaigns(options);
                foreach (var data in lists.Data)
                {
                    txtCampaignTitle.Text = data.Title != null ? data.Title.Trim() : "";
                    txtCampaignSubject.Text = data.Subject != null ? data.Subject.Trim() : "";
                    txtCampaignFromName.Text = data.FromName != null ? data.FromName.Trim() : "";
                    txtCampaignFromEmail.Text = data.FromEmail != null ? data.FromEmail.Trim() : "";
                }
            }
            if (cmbCampaign.SelectedIndex == 0)
            {
                txtCampaignTitle.Text = "";
                txtCampaignSubject.Text = "";
                txtCampaignFromName.Text = "";
                txtCampaignFromEmail.Text = "";
            }
        }
        /// <summary>
        /// Open Settings form on click of menustrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Send Campaign 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendCampain_Click(object sender, EventArgs e)
        {
            SendCampaign();
        }
        /// <summary>
        /// After confirmation send campaign
        /// </summary>
        public void SendCampaign()
        {
            if (ValidateFields())
            {
                var confirmResult = MessageBox.Show("Do you want to send Campaign ?",
                                                "Send Campaign",
                                                MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string listId = string.Empty;
                    string campaignId = cmbCampaign.SelectedValue.ToString();
                    CampaignFilter options = new CampaignFilter();
                    options.CampaignId = campaignId;
                    // Loading panel
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        //Send Campaign
                        CampaignActionResult result = Manager.SendCampaign(campaignId);
                        if (result.Complete)
                        {
                            if (chkEnableSMS.Checked)
                            {
                                bool flag = true;
                                int count = 0;
                                while (flag)
                                {
                                    List<EmailParameter> emails = new List<EmailParameter>();
                                    SentToLimits opt = new SentToLimits();
                                    opt.Status = "sent";
                                    opt.Start = count;
                                    opt.Limit = 100;

                                    bool isCampaignSend = false;
                                    while (!isCampaignSend)
                                    {
                                        CampaignFilter filter = new CampaignFilter();
                                        filter.CampaignId = campaignId;
                                        //Get Sent Campaign
                                        CampaignListResult lists = Manager.GetCampaigns(filter);
                                        foreach (var l in lists.Data)
                                        {
                                            if (l.Status.Trim() == "sent")
                                            {
                                                isCampaignSend = true;
                                                SentToMembers results = Manager.GetReportSentTo(campaignId, opt);
                                                if (results.Data.Count == 0)
                                                {
                                                    flag = false;
                                                    break;
                                                }
                                                foreach (var i in results.Data)
                                                {
                                                    string message = txtMessage.Text.Trim();
                                                    string phone = string.Empty;
                                                    foreach (var j in i.Member.MemberMergeInfo)
                                                    {
                                                        if (message.IndexOf(j.Key.Trim()) != -1)
                                                        {

                                                            message = message.Replace("*|" + j.Key.Trim() + "|*", j.Value != null ? j.Value.ToString() : "");
                                                        }
                                                        if (cmbFieldPhone.SelectedIndex > 0 && cmbFieldPhone.SelectedItem != null)
                                                        {
                                                            if (cmbFieldPhone.Text.Trim() == j.Key.ToString())
                                                            {
                                                                if (j.Value != null && !string.IsNullOrEmpty(j.Value.ToString()))
                                                                {
                                                                    phone = j.Value.ToString();
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (message.IndexOf("EMAIL") != -1)
                                                    {
                                                        message = message.Replace("*|EMAIL|*", i.Member.Email.ToString());
                                                    }
                                                    if (!string.IsNullOrEmpty(phone))
                                                    {
                                                        //Send SMS
                                                        string smsResult = SmsSender.SendSMS(phone.Trim(), NexmoFromNumber, NexmoAPI, NexmoSecretKey, HttpUtility.UrlEncode(message));
                                                    }
                                                }
                                                break;
                                            }
                                        }
                                    }

                                    count++;
                                }
                            }
                        }
                        MessageBox.Show("Campaign sent successfully");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }
        /// <summary>
        /// Bind phone type field
        /// </summary>
        public void BindFields()
        {

            List<MailChimpList> mailChimpField = new List<MailChimpList>();
            List<MailChimpList> mailChimpPhoneField = new List<MailChimpList>();
            mailChimpPhoneField.Add(new MailChimpList("0", "Select recipient field"));
            string listId = string.Empty;
            string campaignId = cmbCampaign.SelectedValue.ToString();
            CampaignFilter options = new CampaignFilter();
            options.CampaignId = campaignId;
            CampaignListResult lists = Manager.GetCampaigns(options);

            foreach (var data in lists.Data)
            {
                listId = data.ListId;
                break;
            }
            //--member of list
            List<EmailParameter> emails = new List<EmailParameter>();
            IEnumerable<string> listEnum = new string[] { listId.ToString() };
            MergeVarResult results = Manager.GetMergeVars(listEnum);
            foreach (var list in results.Data)
            {
                foreach (var mergeVars in list.MergeVars)
                {
                    mailChimpField.Add(new MailChimpList(mergeVars.Id.ToString(), mergeVars.Tag));
                    // Get only Phone type field value
                    if (mergeVars.FieldType == "phone")
                    {
                        mailChimpPhoneField.Add(new MailChimpList(mergeVars.Id.ToString(), mergeVars.Tag));
                    }
                }
            }

            if (mailChimpField != null && mailChimpField.Count > 0)
            {

                lstboxFields.Items.Clear();
                lstboxFields.Items.AddRange(mailChimpField.ToArray());
                lstboxFields.DisplayMember = "Name";

                cmbFieldPhone.DisplayMember = "Name";
                cmbFieldPhone.ValueMember = "Id";
                cmbFieldPhone.DataSource = mailChimpPhoneField;
            }
        }
        /// <summary>
        ///Change button text according to checkbox value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkEnableSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableSMS.Checked)
            {
                btnNextCampaign.Text = "Next";
            }
            else
            {
                btnNextCampaign.Text = "Send Campaign";
            }
        }
        /// <summary>
        /// Hide Settings form if Settings form is open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailChimpCampaign_Shown(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool isOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Settings")
                {
                    frm.Hide();
                }
            }
        }
        /// <summary>
        /// Add tag value in Message textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstboxFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var insertText = "*|" + lstboxFields.Text + "|*";
            var selectionIndex = txtMessage.SelectionStart;
            txtMessage.Text = txtMessage.Text.Insert(selectionIndex, insertText);
            txtMessage.SelectionStart = selectionIndex + insertText.Length;
        }
        /// <summary>
        /// Display Campaign panel and hide NexmoMessage panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlNexmoMessage.Visible = false;
            pnlCampaign.Visible = true;
        }
        public string HTMLEncodeSpecialChars(string text)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in text)
            {
                if (c > 127) // special chars
                    sb.Append(String.Format("&#{0};", (int)c));
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
