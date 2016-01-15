using CRMNexmo.Plugins;
using MailChimp;
using MailChimp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace NexmoWithMailChimp
{
    public partial class Settings : Form
    {
        SmsSender SmsSender = new SmsSender();
        string FileName = "settings.xml";
        string FromNumber = string.Empty;
        public Settings()
        {
            InitializeComponent();
            ReadSettings();
        }
        /// <summary>
        /// According to setting.xml value display Save or Update button.
        /// </summary>
        public void ReadSettings()
        {
            try
            {
                if (!ValidateXMLSettings())
                {
                    btnSave.Text = "Save";
                }
                else
                {
                    btnSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Validate setting.xml file for check is settings already saved or not
        /// </summary>
        /// <returns>true or false</returns>
        public bool ValidateXMLSettings()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FileName);

            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/settings/nexmo");
            foreach (XmlNode node in nodeList)
            {
                txtNexmoAPI.Text = node.SelectSingleNode("api") != null ? node.SelectSingleNode("api").InnerText : "";
                txtNexmoSecretKey.Text = node.SelectSingleNode("secret-key") != null ? node.SelectSingleNode("secret-key").InnerText : "";
            }

            XmlNodeList mailchimpList = xmlDoc.DocumentElement.SelectNodes("/settings/mailchimp");
            foreach (XmlNode node in mailchimpList)
            {
                txtMailChimpAPI.Text = node.SelectSingleNode("api") != null ? node.SelectSingleNode("api").InnerText : "";
            }
            if (string.IsNullOrEmpty(txtNexmoAPI.Text.Trim())
                  && string.IsNullOrEmpty(txtNexmoSecretKey.Text.Trim())
                  && string.IsNullOrEmpty(txtMailChimpAPI.Text.Trim())
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Save Nexmo Settings and MailChimp Settings in settings.xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ValidateFields())
                {
                    XmlDocument doc = new XmlDocument();

                    XmlElement settings = doc.CreateElement(string.Empty, "settings", string.Empty);
                    doc.AppendChild(settings);

                    XmlElement nexmo = doc.CreateElement(string.Empty, "nexmo", string.Empty);
                    settings.AppendChild(nexmo);

                    XmlElement api = doc.CreateElement(string.Empty, "api", string.Empty);
                    XmlText nexmoApi = doc.CreateTextNode(txtNexmoAPI.Text.Trim().ToString());
                    api.AppendChild(nexmoApi);
                    nexmo.AppendChild(api);

                    XmlElement secretKey = doc.CreateElement(string.Empty, "secret-key", string.Empty);
                    XmlText key = doc.CreateTextNode(txtNexmoSecretKey.Text.Trim().ToString());
                    secretKey.AppendChild(key);
                    nexmo.AppendChild(secretKey);

                    XmlElement fromNumber = doc.CreateElement(string.Empty, "from-number", string.Empty);
                    XmlText number = doc.CreateTextNode(FromNumber.Trim().ToString());
                    fromNumber.AppendChild(number);
                    nexmo.AppendChild(fromNumber);


                    //--MailChimp
                    XmlElement mailchimp = doc.CreateElement(string.Empty, "mailchimp", string.Empty);
                    settings.AppendChild(mailchimp);

                    XmlElement mailchimpAPI = doc.CreateElement(string.Empty, "api", string.Empty);
                    XmlText apitext = doc.CreateTextNode(txtMailChimpAPI.Text.Trim().ToString());
                    mailchimpAPI.AppendChild(apitext);
                    mailchimp.AppendChild(mailchimpAPI);

                    doc.Save(FileName);

                    System.Security.AccessControl.FileSecurity fsec = System.IO.File.GetAccessControl(FileName);
                    fsec.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule("Everyone", System.Security.AccessControl.FileSystemRights.Modify, System.Security.AccessControl.AccessControlType.Allow));
                    System.IO.File.SetAccessControl(FileName, fsec);
                    MailChimpCampaign nexmoForm = new MailChimpCampaign();
                    nexmoForm.ShowDialog();

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
        /// Validate Nexmo Settings and MailChimp Settings
        /// </summary>
        /// <returns>true or false</returns>
        public bool ValidateFields()
        {
            if (string.IsNullOrEmpty(txtNexmoAPI.Text.Trim()))
            {
                MessageBox.Show("Please enter the Nexmo Key.", "Nexmo Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNexmoAPI.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNexmoSecretKey.Text.Trim()))
            {
                MessageBox.Show("Please enter the Nexmo Secret. ", "Nexmo Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNexmoSecretKey.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMailChimpAPI.Text.Trim()))
            {
                MessageBox.Show("Please enter the MailChimp Api Key. ", "MailChimp Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMailChimpAPI.Focus();
                return false;
            }

            try
            {
                string fromNumber = SmsSender.GetAccountNumber(txtNexmoAPI.Text.Trim(), txtNexmoSecretKey.Text.Trim());
                if (string.IsNullOrEmpty(fromNumber.Trim()))
                {
                    MessageBox.Show("Not found MISDN number in Nexmo.", "Nexmo Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    FromNumber = fromNumber;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid Nexmo Key and Secret.", "Nexmo Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            try
            {
                MailChimpManager mc = new MailChimpManager(txtMailChimpAPI.Text.Trim());
                var ss = mc.GetVerifiedDomains();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid MailChimp API Key.", "MailChimp Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Open MailChimpCampaign form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!ValidateXMLSettings())
            {
                this.Close();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    MailChimpCampaign nexmoForm = new MailChimpCampaign();
                    nexmoForm.ShowDialog();
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
}
