namespace NexmoWithMailChimp
{
    partial class Settings
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
            this.lblNexMo = new System.Windows.Forms.Label();
            this.txtNexmoAPI = new System.Windows.Forms.TextBox();
            this.Textbox = new System.Windows.Forms.Label();
            this.txtNexmoSecretKey = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMailChimpApi = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMailChimpAPI = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNexMo
            // 
            this.lblNexMo.AutoSize = true;
            this.lblNexMo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNexMo.Location = new System.Drawing.Point(16, 60);
            this.lblNexMo.Name = "lblNexMo";
            this.lblNexMo.Size = new System.Drawing.Size(85, 20);
            this.lblNexMo.TabIndex = 5;
            this.lblNexMo.Text = "Nexmo Key";
            // 
            // txtNexmoAPI
            // 
            this.txtNexmoAPI.Location = new System.Drawing.Point(20, 86);
            this.txtNexmoAPI.Name = "txtNexmoAPI";
            this.txtNexmoAPI.Size = new System.Drawing.Size(440, 27);
            this.txtNexmoAPI.TabIndex = 0;
            // 
            // Textbox
            // 
            this.Textbox.AutoSize = true;
            this.Textbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox.Location = new System.Drawing.Point(17, 124);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(102, 20);
            this.Textbox.TabIndex = 7;
            this.Textbox.Text = "Nexmo Secret";
            // 
            // txtNexmoSecretKey
            // 
            this.txtNexmoSecretKey.Location = new System.Drawing.Point(20, 149);
            this.txtNexmoSecretKey.Name = "txtNexmoSecretKey";
            this.txtNexmoSecretKey.Size = new System.Drawing.Size(439, 27);
            this.txtNexmoSecretKey.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblMailChimpApi);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMailChimpAPI);
            this.panel1.Controls.Add(this.txtNexmoSecretKey);
            this.panel1.Controls.Add(this.Textbox);
            this.panel1.Controls.Add(this.txtNexmoAPI);
            this.panel1.Controls.Add(this.lblNexMo);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 405);
            this.panel1.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.BackgroundImage = global::NexmoWithMailChimp.Properties.Resources.blue_btn;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(334, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(15, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "MailChimp Settings";
            // 
            // lblMailChimpApi
            // 
            this.lblMailChimpApi.AutoSize = true;
            this.lblMailChimpApi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailChimpApi.Location = new System.Drawing.Point(17, 253);
            this.lblMailChimpApi.Name = "lblMailChimpApi";
            this.lblMailChimpApi.Size = new System.Drawing.Size(135, 20);
            this.lblMailChimpApi.TabIndex = 3;
            this.lblMailChimpApi.Text = "MailChimp API Key";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BackgroundImage = global::NexmoWithMailChimp.Properties.Resources.blue_btn;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(194, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nexmo Settings";
            // 
            // txtMailChimpAPI
            // 
            this.txtMailChimpAPI.Location = new System.Drawing.Point(21, 285);
            this.txtMailChimpAPI.Name = "txtMailChimpAPI";
            this.txtMailChimpAPI.Size = new System.Drawing.Size(439, 27);
            this.txtMailChimpAPI.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NexmoWithMailChimp.Properties.Resources.nexmo_logo;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(535, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "MailChimp with Nexmo SMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNexMo;
        private System.Windows.Forms.TextBox txtNexmoAPI;
        private System.Windows.Forms.Label Textbox;
        private System.Windows.Forms.TextBox txtNexmoSecretKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMailChimpApi;
        private System.Windows.Forms.TextBox txtMailChimpAPI;
    }
}