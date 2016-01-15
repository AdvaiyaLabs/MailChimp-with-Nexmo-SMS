namespace NexmoWithMailChimp
{
    partial class NexMO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.chkEnableSMS = new System.Windows.Forms.CheckBox();
            this.pnlTemplate = new System.Windows.Forms.Panel();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.lblListId = new System.Windows.Forms.Label();
            this.btnNextTemplate = new System.Windows.Forms.Button();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMailChimp = new System.Windows.Forms.Panel();
            this.btnCamaignSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCampaignToName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCampaignSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCampaignFromName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCampaignFromEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCampaignTitle = new System.Windows.Forms.TextBox();
            this.pnlNexmoMessage = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFromNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlTemplate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMailChimp.SuspendLayout();
            this.pnlNexmoMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(100, 12);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(340, 21);
            this.cmbTemplate.TabIndex = 5;
            // 
            // chkEnableSMS
            // 
            this.chkEnableSMS.AutoSize = true;
            this.chkEnableSMS.Location = new System.Drawing.Point(100, 98);
            this.chkEnableSMS.Name = "chkEnableSMS";
            this.chkEnableSMS.Size = new System.Drawing.Size(85, 17);
            this.chkEnableSMS.TabIndex = 6;
            this.chkEnableSMS.Text = "Enable SMS";
            this.chkEnableSMS.UseVisualStyleBackColor = true;
            // 
            // pnlTemplate
            // 
            this.pnlTemplate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlTemplate.Controls.Add(this.lblTemplate);
            this.pnlTemplate.Controls.Add(this.chkEnableSMS);
            this.pnlTemplate.Controls.Add(this.lblListId);
            this.pnlTemplate.Controls.Add(this.btnNextTemplate);
            this.pnlTemplate.Controls.Add(this.cmbList);
            this.pnlTemplate.Controls.Add(this.cmbTemplate);
            this.pnlTemplate.Location = new System.Drawing.Point(21, 42);
            this.pnlTemplate.Name = "pnlTemplate";
            this.pnlTemplate.Size = new System.Drawing.Size(464, 156);
            this.pnlTemplate.TabIndex = 7;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(17, 20);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(51, 13);
            this.lblTemplate.TabIndex = 8;
            this.lblTemplate.Text = "Template";
            // 
            // lblListId
            // 
            this.lblListId.AutoSize = true;
            this.lblListId.Location = new System.Drawing.Point(18, 58);
            this.lblListId.Name = "lblListId";
            this.lblListId.Size = new System.Drawing.Size(32, 13);
            this.lblListId.TabIndex = 10;
            this.lblListId.Text = "ListId";
            // 
            // btnNextTemplate
            // 
            this.btnNextTemplate.Location = new System.Drawing.Point(315, 118);
            this.btnNextTemplate.Name = "btnNextTemplate";
            this.btnNextTemplate.Size = new System.Drawing.Size(125, 23);
            this.btnNextTemplate.TabIndex = 8;
            this.btnNextTemplate.Text = "Next";
            this.btnNextTemplate.UseVisualStyleBackColor = true;
            this.btnNextTemplate.Click += new System.EventHandler(this.btnNextTemplate_Click);
            // 
            // cmbList
            // 
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Location = new System.Drawing.Point(100, 54);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(340, 21);
            this.cmbList.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // pnlMailChimp
            // 
            this.pnlMailChimp.Controls.Add(this.btnCamaignSend);
            this.pnlMailChimp.Controls.Add(this.label6);
            this.pnlMailChimp.Controls.Add(this.label7);
            this.pnlMailChimp.Controls.Add(this.txtCampaignToName);
            this.pnlMailChimp.Controls.Add(this.label4);
            this.pnlMailChimp.Controls.Add(this.txtCampaignSubject);
            this.pnlMailChimp.Controls.Add(this.label3);
            this.pnlMailChimp.Controls.Add(this.txtCampaignFromName);
            this.pnlMailChimp.Controls.Add(this.label2);
            this.pnlMailChimp.Controls.Add(this.txtCampaignFromEmail);
            this.pnlMailChimp.Controls.Add(this.label1);
            this.pnlMailChimp.Controls.Add(this.txtCampaignTitle);
            this.pnlMailChimp.Location = new System.Drawing.Point(21, 220);
            this.pnlMailChimp.Name = "pnlMailChimp";
            this.pnlMailChimp.Size = new System.Drawing.Size(464, 285);
            this.pnlMailChimp.TabIndex = 9;
            this.pnlMailChimp.Visible = false;
            // 
            // btnCamaignSend
            // 
            this.btnCamaignSend.Location = new System.Drawing.Point(315, 247);
            this.btnCamaignSend.Name = "btnCamaignSend";
            this.btnCamaignSend.Size = new System.Drawing.Size(125, 23);
            this.btnCamaignSend.TabIndex = 11;
            this.btnCamaignSend.Text = "Next";
            this.btnCamaignSend.UseVisualStyleBackColor = true;
            this.btnCamaignSend.Click += new System.EventHandler(this.btnCamaignSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Campaign Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Campaign To Name";
            // 
            // txtCampaignToName
            // 
            this.txtCampaignToName.Location = new System.Drawing.Point(114, 183);
            this.txtCampaignToName.Name = "txtCampaignToName";
            this.txtCampaignToName.Size = new System.Drawing.Size(336, 20);
            this.txtCampaignToName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Campaign Subject";
            // 
            // txtCampaignSubject
            // 
            this.txtCampaignSubject.Location = new System.Drawing.Point(114, 110);
            this.txtCampaignSubject.Name = "txtCampaignSubject";
            this.txtCampaignSubject.Size = new System.Drawing.Size(336, 20);
            this.txtCampaignSubject.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Campaign From Name";
            // 
            // txtCampaignFromName
            // 
            this.txtCampaignFromName.Location = new System.Drawing.Point(114, 147);
            this.txtCampaignFromName.Name = "txtCampaignFromName";
            this.txtCampaignFromName.Size = new System.Drawing.Size(336, 20);
            this.txtCampaignFromName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Campaign From Email";
            // 
            // txtCampaignFromEmail
            // 
            this.txtCampaignFromEmail.Location = new System.Drawing.Point(114, 221);
            this.txtCampaignFromEmail.Name = "txtCampaignFromEmail";
            this.txtCampaignFromEmail.Size = new System.Drawing.Size(336, 20);
            this.txtCampaignFromEmail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Campaign Title";
            // 
            // txtCampaignTitle
            // 
            this.txtCampaignTitle.Location = new System.Drawing.Point(114, 72);
            this.txtCampaignTitle.Name = "txtCampaignTitle";
            this.txtCampaignTitle.Size = new System.Drawing.Size(336, 20);
            this.txtCampaignTitle.TabIndex = 16;
            // 
            // pnlNexmoMessage
            // 
            this.pnlNexmoMessage.Controls.Add(this.txtMessage);
            this.pnlNexmoMessage.Controls.Add(this.label9);
            this.pnlNexmoMessage.Controls.Add(this.txtFromNumber);
            this.pnlNexmoMessage.Controls.Add(this.label8);
            this.pnlNexmoMessage.Location = new System.Drawing.Point(21, 523);
            this.pnlNexmoMessage.Name = "pnlNexmoMessage";
            this.pnlNexmoMessage.Size = new System.Drawing.Size(464, 150);
            this.pnlNexmoMessage.TabIndex = 26;
            this.pnlNexmoMessage.Visible = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(115, 63);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(336, 64);
            this.txtMessage.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Message";
            // 
            // txtFromNumber
            // 
            this.txtFromNumber.Location = new System.Drawing.Point(115, 24);
            this.txtFromNumber.Name = "txtFromNumber";
            this.txtFromNumber.Size = new System.Drawing.Size(336, 20);
            this.txtFromNumber.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "From Mobile Number";
            // 
            // NexMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(514, 685);
            this.Controls.Add(this.pnlNexmoMessage);
            this.Controls.Add(this.pnlMailChimp);
            this.Controls.Add(this.pnlTemplate);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NexMO";
            this.Text = "NexMo";
            this.pnlTemplate.ResumeLayout(false);
            this.pnlTemplate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMailChimp.ResumeLayout(false);
            this.pnlMailChimp.PerformLayout();
            this.pnlNexmoMessage.ResumeLayout(false);
            this.pnlNexmoMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.CheckBox chkEnableSMS;
        private System.Windows.Forms.Panel pnlTemplate;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Button btnNextTemplate;
        private System.Windows.Forms.Label lblListId;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMailChimp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCampaignToName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCampaignSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCampaignFromName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCampaignFromEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCampaignTitle;
        private System.Windows.Forms.Button btnCamaignSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlNexmoMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFromNumber;
        private System.Windows.Forms.Label label8;

    }
}

