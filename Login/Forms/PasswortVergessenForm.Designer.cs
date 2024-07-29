namespace Login
{
    partial class PasswortVergessenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswortVergessenForm));
            this.LabelEmailV = new System.Windows.Forms.Label();
            this.LabelHinweis = new System.Windows.Forms.Label();
            this.TextboxEmailV = new System.Windows.Forms.TextBox();
            this.LabelBenutzernameV = new System.Windows.Forms.Label();
            this.TextboxBenutzernameV = new System.Windows.Forms.TextBox();
            this.ButtonBestätigenV = new System.Windows.Forms.Button();
            this.LabelEmailNichtVerfügbarV = new System.Windows.Forms.Label();
            this.LabelEmailFormatV = new System.Windows.Forms.Label();
            this.ButtonZurückPasswortVergessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelEmailV
            // 
            this.LabelEmailV.AutoSize = true;
            this.LabelEmailV.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmailV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelEmailV.Location = new System.Drawing.Point(268, 179);
            this.LabelEmailV.Name = "LabelEmailV";
            this.LabelEmailV.Size = new System.Drawing.Size(49, 17);
            this.LabelEmailV.TabIndex = 0;
            this.LabelEmailV.Text = "E-Mail:";
            // 
            // LabelHinweis
            // 
            this.LabelHinweis.AutoSize = true;
            this.LabelHinweis.BackColor = System.Drawing.Color.Red;
            this.LabelHinweis.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHinweis.ForeColor = System.Drawing.Color.White;
            this.LabelHinweis.Location = new System.Drawing.Point(46, 114);
            this.LabelHinweis.Name = "LabelHinweis";
            this.LabelHinweis.Size = new System.Drawing.Size(612, 17);
            this.LabelHinweis.TabIndex = 1;
            this.LabelHinweis.Text = "Um Ihr Passwort zurückzusetzen geben Sie bitte Ihre E-Mail Adresse und Ihren Benu" +
    "tzernamen ein";
            // 
            // TextboxEmailV
            // 
            this.TextboxEmailV.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxEmailV.ForeColor = System.Drawing.Color.Gray;
            this.TextboxEmailV.Location = new System.Drawing.Point(272, 196);
            this.TextboxEmailV.Name = "TextboxEmailV";
            this.TextboxEmailV.Size = new System.Drawing.Size(214, 29);
            this.TextboxEmailV.TabIndex = 2;
            this.TextboxEmailV.TextChanged += new System.EventHandler(this.TextboxEmailV_TextChanged);
            this.TextboxEmailV.Leave += new System.EventHandler(this.TextboxEmailV_Leave);
            this.TextboxEmailV.MouseLeave += new System.EventHandler(this.Textbox_MouseLeave);
            this.TextboxEmailV.MouseHover += new System.EventHandler(this.Textbox_MouseHover);
            // 
            // LabelBenutzernameV
            // 
            this.LabelBenutzernameV.AutoSize = true;
            this.LabelBenutzernameV.BackColor = System.Drawing.Color.Transparent;
            this.LabelBenutzernameV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBenutzernameV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelBenutzernameV.Location = new System.Drawing.Point(268, 237);
            this.LabelBenutzernameV.Name = "LabelBenutzernameV";
            this.LabelBenutzernameV.Size = new System.Drawing.Size(102, 17);
            this.LabelBenutzernameV.TabIndex = 3;
            this.LabelBenutzernameV.Text = "Benutzername:";
            // 
            // TextboxBenutzernameV
            // 
            this.TextboxBenutzernameV.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxBenutzernameV.ForeColor = System.Drawing.Color.Silver;
            this.TextboxBenutzernameV.Location = new System.Drawing.Point(272, 251);
            this.TextboxBenutzernameV.Name = "TextboxBenutzernameV";
            this.TextboxBenutzernameV.Size = new System.Drawing.Size(214, 29);
            this.TextboxBenutzernameV.TabIndex = 4;
            this.TextboxBenutzernameV.TextChanged += new System.EventHandler(this.TextboxBenutzernameV_TextChanged);
            this.TextboxBenutzernameV.MouseLeave += new System.EventHandler(this.Textbox_MouseLeave);
            this.TextboxBenutzernameV.MouseHover += new System.EventHandler(this.Textbox_MouseHover);
            // 
            // ButtonBestätigenV
            // 
            this.ButtonBestätigenV.AutoSize = true;
            this.ButtonBestätigenV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonBestätigenV.Enabled = false;
            this.ButtonBestätigenV.FlatAppearance.BorderSize = 0;
            this.ButtonBestätigenV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBestätigenV.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBestätigenV.ForeColor = System.Drawing.Color.White;
            this.ButtonBestätigenV.Location = new System.Drawing.Point(327, 303);
            this.ButtonBestätigenV.Name = "ButtonBestätigenV";
            this.ButtonBestätigenV.Size = new System.Drawing.Size(101, 32);
            this.ButtonBestätigenV.TabIndex = 32;
            this.ButtonBestätigenV.Text = "Bestätigen";
            this.ButtonBestätigenV.UseVisualStyleBackColor = false;
            this.ButtonBestätigenV.Click += new System.EventHandler(this.ButtonBestätigenV_Click);
            // 
            // LabelEmailNichtVerfügbarV
            // 
            this.LabelEmailNichtVerfügbarV.AutoSize = true;
            this.LabelEmailNichtVerfügbarV.BackColor = System.Drawing.Color.Red;
            this.LabelEmailNichtVerfügbarV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailNichtVerfügbarV.ForeColor = System.Drawing.Color.White;
            this.LabelEmailNichtVerfügbarV.Location = new System.Drawing.Point(269, 283);
            this.LabelEmailNichtVerfügbarV.Name = "LabelEmailNichtVerfügbarV";
            this.LabelEmailNichtVerfügbarV.Size = new System.Drawing.Size(294, 17);
            this.LabelEmailNichtVerfügbarV.TabIndex = 33;
            this.LabelEmailNichtVerfügbarV.Text = "Ein Konto mit diesen Daten ist nicht verfügbar!";
            this.LabelEmailNichtVerfügbarV.Visible = false;
            // 
            // LabelEmailFormatV
            // 
            this.LabelEmailFormatV.AutoSize = true;
            this.LabelEmailFormatV.BackColor = System.Drawing.Color.Red;
            this.LabelEmailFormatV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailFormatV.ForeColor = System.Drawing.Color.White;
            this.LabelEmailFormatV.Location = new System.Drawing.Point(490, 196);
            this.LabelEmailFormatV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmailFormatV.Name = "LabelEmailFormatV";
            this.LabelEmailFormatV.Size = new System.Drawing.Size(215, 34);
            this.LabelEmailFormatV.TabIndex = 35;
            this.LabelEmailFormatV.Text = "Die eingegebene E-Mail entspricht\r\n keinem gültigen Format!";
            this.LabelEmailFormatV.Visible = false;
            // 
            // ButtonZurückPasswortVergessen
            // 
            this.ButtonZurückPasswortVergessen.AutoSize = true;
            this.ButtonZurückPasswortVergessen.BackColor = System.Drawing.Color.Gray;
            this.ButtonZurückPasswortVergessen.FlatAppearance.BorderSize = 0;
            this.ButtonZurückPasswortVergessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZurückPasswortVergessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZurückPasswortVergessen.Image = global::Login.Properties.Resources.circle_back;
            this.ButtonZurückPasswortVergessen.Location = new System.Drawing.Point(49, 61);
            this.ButtonZurückPasswortVergessen.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonZurückPasswortVergessen.Name = "ButtonZurückPasswortVergessen";
            this.ButtonZurückPasswortVergessen.Size = new System.Drawing.Size(75, 32);
            this.ButtonZurückPasswortVergessen.TabIndex = 36;
            this.ButtonZurückPasswortVergessen.UseVisualStyleBackColor = false;
            this.ButtonZurückPasswortVergessen.Click += new System.EventHandler(this.ButtonZurückPasswortVergessen_Click);
            this.ButtonZurückPasswortVergessen.MouseLeave += new System.EventHandler(this.ButtonZurückPasswortVergessen_MouseLeave);
            this.ButtonZurückPasswortVergessen.MouseHover += new System.EventHandler(this.ButtonZurückPasswortVergessen_MouseHover);
            // 
            // PasswortVergessenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 396);
            this.Controls.Add(this.ButtonZurückPasswortVergessen);
            this.Controls.Add(this.LabelEmailFormatV);
            this.Controls.Add(this.LabelEmailNichtVerfügbarV);
            this.Controls.Add(this.ButtonBestätigenV);
            this.Controls.Add(this.TextboxBenutzernameV);
            this.Controls.Add(this.LabelBenutzernameV);
            this.Controls.Add(this.TextboxEmailV);
            this.Controls.Add(this.LabelHinweis);
            this.Controls.Add(this.LabelEmailV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswortVergessenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwort vergessen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswortVergessenForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEmailV;
        private System.Windows.Forms.Label LabelHinweis;
        private System.Windows.Forms.TextBox TextboxEmailV;
        private System.Windows.Forms.Label LabelBenutzernameV;
        private System.Windows.Forms.TextBox TextboxBenutzernameV;
        private System.Windows.Forms.Button ButtonBestätigenV;
        private System.Windows.Forms.Label LabelEmailNichtVerfügbarV;
        private System.Windows.Forms.Label LabelEmailFormatV;
        private System.Windows.Forms.Button ButtonZurückPasswortVergessen;
    }
}