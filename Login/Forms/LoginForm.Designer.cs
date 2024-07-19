namespace Login
{
    partial class LoginBildschirm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginBildschirm));
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonRegistrieren = new System.Windows.Forms.Button();
            this.TextfeldPasswort = new System.Windows.Forms.TextBox();
            this.TextfeldEmail = new System.Windows.Forms.TextBox();
            this.LabelEmailBenutzername = new System.Windows.Forms.Label();
            this.LabelPasswort = new System.Windows.Forms.Label();
            this.LabelPasswortStimmtNicht = new System.Windows.Forms.Label();
            this.linkLabelPasswortVergessen = new System.Windows.Forms.LinkLabel();
            this.CheckboxAngemeldetbBleiben = new System.Windows.Forms.CheckBox();
            this.ButtonPasswortSicherheit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.BackColor = System.Drawing.Color.Blue;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(442, 328);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonLogin.Size = new System.Drawing.Size(108, 32);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.ButtonLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonLogin_MouseDown);
            this.ButtonLogin.MouseLeave += new System.EventHandler(this.ButtonLogin_MouseLeave);
            this.ButtonLogin.MouseHover += new System.EventHandler(this.ButtonLogin_MouseHover);
            // 
            // ButtonRegistrieren
            // 
            this.ButtonRegistrieren.AutoSize = true;
            this.ButtonRegistrieren.BackColor = System.Drawing.Color.LightGray;
            this.ButtonRegistrieren.FlatAppearance.BorderSize = 0;
            this.ButtonRegistrieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegistrieren.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegistrieren.ForeColor = System.Drawing.Color.White;
            this.ButtonRegistrieren.Location = new System.Drawing.Point(442, 379);
            this.ButtonRegistrieren.Name = "ButtonRegistrieren";
            this.ButtonRegistrieren.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonRegistrieren.Size = new System.Drawing.Size(108, 32);
            this.ButtonRegistrieren.TabIndex = 4;
            this.ButtonRegistrieren.Text = "Registrieren";
            this.ButtonRegistrieren.UseVisualStyleBackColor = false;
            this.ButtonRegistrieren.Click += new System.EventHandler(this.ButtonRegistrieren_Click);
            this.ButtonRegistrieren.MouseHover += new System.EventHandler(this.ButtonRegistrieren_MouseHover);
            // 
            // TextfeldPasswort
            // 
            this.TextfeldPasswort.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextfeldPasswort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextfeldPasswort.Location = new System.Drawing.Point(384, 243);
            this.TextfeldPasswort.Margin = new System.Windows.Forms.Padding(0);
            this.TextfeldPasswort.Name = "TextfeldPasswort";
            this.TextfeldPasswort.Size = new System.Drawing.Size(235, 29);
            this.TextfeldPasswort.TabIndex = 2;
            this.TextfeldPasswort.TextChanged += new System.EventHandler(this.TextfeldPasswort_TextChanged);
            this.TextfeldPasswort.Enter += new System.EventHandler(this.TextfeldPasswort_Enter);
            this.TextfeldPasswort.MouseLeave += new System.EventHandler(this.TextfeldPasswort_MouseLeave);
            this.TextfeldPasswort.MouseHover += new System.EventHandler(this.TextfeldPasswort_MouseHover);
            // 
            // TextfeldEmail
            // 
            this.TextfeldEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TextfeldEmail.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextfeldEmail.ForeColor = System.Drawing.Color.Black;
            this.TextfeldEmail.Location = new System.Drawing.Point(384, 183);
            this.TextfeldEmail.Margin = new System.Windows.Forms.Padding(0);
            this.TextfeldEmail.Name = "TextfeldEmail";
            this.TextfeldEmail.Size = new System.Drawing.Size(235, 29);
            this.TextfeldEmail.TabIndex = 1;
            this.TextfeldEmail.TextChanged += new System.EventHandler(this.TextfeldEmail_TextChanged);
            this.TextfeldEmail.MouseLeave += new System.EventHandler(this.TextfeldEmail_MouseLeave);
            this.TextfeldEmail.MouseHover += new System.EventHandler(this.TextfeldEmail_MouseHover);
            // 
            // LabelEmailBenutzername
            // 
            this.LabelEmailBenutzername.AutoSize = true;
            this.LabelEmailBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmailBenutzername.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.LabelEmailBenutzername.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelEmailBenutzername.Location = new System.Drawing.Point(380, 163);
            this.LabelEmailBenutzername.Name = "LabelEmailBenutzername";
            this.LabelEmailBenutzername.Size = new System.Drawing.Size(145, 17);
            this.LabelEmailBenutzername.TabIndex = 4;
            this.LabelEmailBenutzername.Text = "Email / Benutzername";
            // 
            // LabelPasswort
            // 
            this.LabelPasswort.AutoSize = true;
            this.LabelPasswort.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswort.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswort.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelPasswort.Location = new System.Drawing.Point(380, 223);
            this.LabelPasswort.Name = "LabelPasswort";
            this.LabelPasswort.Size = new System.Drawing.Size(68, 17);
            this.LabelPasswort.TabIndex = 5;
            this.LabelPasswort.Text = "Passwort";
            // 
            // LabelPasswortStimmtNicht
            // 
            this.LabelPasswortStimmtNicht.AutoSize = true;
            this.LabelPasswortStimmtNicht.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswortStimmtNicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortStimmtNicht.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswortStimmtNicht.Location = new System.Drawing.Point(458, 414);
            this.LabelPasswortStimmtNicht.Name = "LabelPasswortStimmtNicht";
            this.LabelPasswortStimmtNicht.Size = new System.Drawing.Size(0, 13);
            this.LabelPasswortStimmtNicht.TabIndex = 22;
            // 
            // linkLabelPasswortVergessen
            // 
            this.linkLabelPasswortVergessen.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabelPasswortVergessen.AutoSize = true;
            this.linkLabelPasswortVergessen.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelPasswortVergessen.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPasswortVergessen.LinkArea = new System.Windows.Forms.LinkArea(0, 19);
            this.linkLabelPasswortVergessen.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelPasswortVergessen.Location = new System.Drawing.Point(381, 280);
            this.linkLabelPasswortVergessen.Name = "linkLabelPasswortVergessen";
            this.linkLabelPasswortVergessen.Size = new System.Drawing.Size(113, 13);
            this.linkLabelPasswortVergessen.TabIndex = 24;
            this.linkLabelPasswortVergessen.TabStop = true;
            this.linkLabelPasswortVergessen.Text = "Passwort vergessen?";
            this.linkLabelPasswortVergessen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPasswortVergessen_LinkClicked);
            // 
            // CheckboxAngemeldetbBleiben
            // 
            this.CheckboxAngemeldetbBleiben.AutoSize = true;
            this.CheckboxAngemeldetbBleiben.BackColor = System.Drawing.Color.Transparent;
            this.CheckboxAngemeldetbBleiben.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxAngemeldetbBleiben.ForeColor = System.Drawing.Color.Gray;
            this.CheckboxAngemeldetbBleiben.Location = new System.Drawing.Point(384, 298);
            this.CheckboxAngemeldetbBleiben.Name = "CheckboxAngemeldetbBleiben";
            this.CheckboxAngemeldetbBleiben.Size = new System.Drawing.Size(148, 21);
            this.CheckboxAngemeldetbBleiben.TabIndex = 25;
            this.CheckboxAngemeldetbBleiben.Text = "Angemeldet bleiben";
            this.CheckboxAngemeldetbBleiben.UseVisualStyleBackColor = false;
            // 
            // ButtonPasswortSicherheit
            // 
            this.ButtonPasswortSicherheit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPasswortSicherheit.FlatAppearance.BorderSize = 0;
            this.ButtonPasswortSicherheit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPasswortSicherheit.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPasswortSicherheit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonPasswortSicherheit.Image = global::Login.Properties.Resources.Auge;
            this.ButtonPasswortSicherheit.Location = new System.Drawing.Point(572, 243);
            this.ButtonPasswortSicherheit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPasswortSicherheit.Name = "ButtonPasswortSicherheit";
            this.ButtonPasswortSicherheit.Size = new System.Drawing.Size(47, 29);
            this.ButtonPasswortSicherheit.TabIndex = 8;
            this.ButtonPasswortSicherheit.UseVisualStyleBackColor = false;
            this.ButtonPasswortSicherheit.Visible = false;
            this.ButtonPasswortSicherheit.Click += new System.EventHandler(this.ButtonPasswortSicherheit_Click);
            this.ButtonPasswortSicherheit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPasswortSicherheit_MouseDown);
            this.ButtonPasswortSicherheit.MouseLeave += new System.EventHandler(this.ButtonPasswortSicherheit_MouseLeave);
            this.ButtonPasswortSicherheit.MouseHover += new System.EventHandler(this.ButtonPasswortSicherheit_MouseHover);
            // 
            // LoginBildschirm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 564);
            this.Controls.Add(this.ButtonPasswortSicherheit);
            this.Controls.Add(this.CheckboxAngemeldetbBleiben);
            this.Controls.Add(this.linkLabelPasswortVergessen);
            this.Controls.Add(this.LabelPasswortStimmtNicht);
            this.Controls.Add(this.LabelPasswort);
            this.Controls.Add(this.LabelEmailBenutzername);
            this.Controls.Add(this.TextfeldEmail);
            this.Controls.Add(this.TextfeldPasswort);
            this.Controls.Add(this.ButtonRegistrieren);
            this.Controls.Add(this.ButtonLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginBildschirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Bildschirm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginBildschirm_FormClosing);
            this.Load += new System.EventHandler(this.LoginBildschirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonRegistrieren;
        private System.Windows.Forms.TextBox TextfeldPasswort;
        private System.Windows.Forms.TextBox TextfeldEmail;
        private System.Windows.Forms.Label LabelEmailBenutzername;
        private System.Windows.Forms.Label LabelPasswort;
        private System.Windows.Forms.Button ButtonPasswortSicherheit;
        private System.Windows.Forms.Label LabelPasswortStimmtNicht;
        private System.Windows.Forms.LinkLabel linkLabelPasswortVergessen;
        private System.Windows.Forms.CheckBox CheckboxAngemeldetbBleiben;
    }
}

