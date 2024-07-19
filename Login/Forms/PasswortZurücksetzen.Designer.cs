namespace Login
{
    partial class PasswortZurücksetzen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswortZurücksetzen));
            this.LabelPwZurücksetzen = new System.Windows.Forms.Label();
            this.TextboxPwZurücksetzen = new System.Windows.Forms.TextBox();
            this.LabelPwWiederholen = new System.Windows.Forms.Label();
            this.TextboxPWZwiederholen = new System.Windows.Forms.TextBox();
            this.ButtonBestätigenPWZ = new System.Windows.Forms.Button();
            this.ButtonZurückPWZ = new System.Windows.Forms.Button();
            this.LabelPasswortVorgabenZ = new System.Windows.Forms.Label();
            this.LabelPasswortFehlerZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPwZurücksetzen
            // 
            this.LabelPwZurücksetzen.AutoSize = true;
            this.LabelPwZurücksetzen.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPwZurücksetzen.Location = new System.Drawing.Point(289, 153);
            this.LabelPwZurücksetzen.Name = "LabelPwZurücksetzen";
            this.LabelPwZurücksetzen.Size = new System.Drawing.Size(113, 17);
            this.LabelPwZurücksetzen.TabIndex = 0;
            this.LabelPwZurücksetzen.Text = "Neues Passwort:";
            // 
            // TextboxPwZurücksetzen
            // 
            this.TextboxPwZurücksetzen.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPwZurücksetzen.ForeColor = System.Drawing.Color.Silver;
            this.TextboxPwZurücksetzen.Location = new System.Drawing.Point(292, 169);
            this.TextboxPwZurücksetzen.Name = "TextboxPwZurücksetzen";
            this.TextboxPwZurücksetzen.Size = new System.Drawing.Size(200, 29);
            this.TextboxPwZurücksetzen.TabIndex = 1;
            this.TextboxPwZurücksetzen.TextChanged += new System.EventHandler(this.TextboxPwZurücksetzen_TextChanged);
            this.TextboxPwZurücksetzen.Enter += new System.EventHandler(this.TextboxPwZurücksetzen_Enter);
            this.TextboxPwZurücksetzen.Leave += new System.EventHandler(this.TextboxPwZurücksetzen_Leave);
            this.TextboxPwZurücksetzen.MouseLeave += new System.EventHandler(this.Textbox_MouseLeave);
            this.TextboxPwZurücksetzen.MouseHover += new System.EventHandler(this.Textbox_MouseHover);
            // 
            // LabelPwWiederholen
            // 
            this.LabelPwWiederholen.AutoSize = true;
            this.LabelPwWiederholen.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPwWiederholen.Location = new System.Drawing.Point(289, 234);
            this.LabelPwWiederholen.Name = "LabelPwWiederholen";
            this.LabelPwWiederholen.Size = new System.Drawing.Size(191, 17);
            this.LabelPwWiederholen.TabIndex = 2;
            this.LabelPwWiederholen.Text = "Neues Passwort wiederholen:";
            // 
            // TextboxPWZwiederholen
            // 
            this.TextboxPWZwiederholen.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPWZwiederholen.ForeColor = System.Drawing.Color.Silver;
            this.TextboxPWZwiederholen.Location = new System.Drawing.Point(292, 251);
            this.TextboxPWZwiederholen.Name = "TextboxPWZwiederholen";
            this.TextboxPWZwiederholen.Size = new System.Drawing.Size(200, 29);
            this.TextboxPWZwiederholen.TabIndex = 3;
            this.TextboxPWZwiederholen.TextChanged += new System.EventHandler(this.TextboxPWZwiederholen_TextChanged);
            this.TextboxPWZwiederholen.Enter += new System.EventHandler(this.TextboxPWZwiederholen_Enter);
            this.TextboxPWZwiederholen.Leave += new System.EventHandler(this.TextboxPWZwiederholen_Leave);
            this.TextboxPWZwiederholen.MouseLeave += new System.EventHandler(this.Textbox_MouseLeave);
            this.TextboxPWZwiederholen.MouseHover += new System.EventHandler(this.Textbox_MouseHover);
            // 
            // ButtonBestätigenPWZ
            // 
            this.ButtonBestätigenPWZ.BackColor = System.Drawing.Color.Silver;
            this.ButtonBestätigenPWZ.Enabled = false;
            this.ButtonBestätigenPWZ.FlatAppearance.BorderSize = 0;
            this.ButtonBestätigenPWZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBestätigenPWZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBestätigenPWZ.ForeColor = System.Drawing.Color.White;
            this.ButtonBestätigenPWZ.Location = new System.Drawing.Point(349, 292);
            this.ButtonBestätigenPWZ.Name = "ButtonBestätigenPWZ";
            this.ButtonBestätigenPWZ.Size = new System.Drawing.Size(87, 27);
            this.ButtonBestätigenPWZ.TabIndex = 4;
            this.ButtonBestätigenPWZ.Text = "Bestätigen";
            this.ButtonBestätigenPWZ.UseVisualStyleBackColor = false;
            this.ButtonBestätigenPWZ.Click += new System.EventHandler(this.ButtonBestätigenPWZ_Click);
            // 
            // ButtonZurückPWZ
            // 
            this.ButtonZurückPWZ.BackColor = System.Drawing.Color.Silver;
            this.ButtonZurückPWZ.FlatAppearance.BorderSize = 0;
            this.ButtonZurückPWZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZurückPWZ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonZurückPWZ.Image = global::Login.Properties.Resources.circle_back;
            this.ButtonZurückPWZ.Location = new System.Drawing.Point(70, 91);
            this.ButtonZurückPWZ.Name = "ButtonZurückPWZ";
            this.ButtonZurückPWZ.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonZurückPWZ.Size = new System.Drawing.Size(63, 35);
            this.ButtonZurückPWZ.TabIndex = 5;
            this.ButtonZurückPWZ.UseVisualStyleBackColor = false;
            this.ButtonZurückPWZ.Click += new System.EventHandler(this.ButtonZurückPWZ_Click);
            // 
            // LabelPasswortVorgabenZ
            // 
            this.LabelPasswortVorgabenZ.AutoSize = true;
            this.LabelPasswortVorgabenZ.BackColor = System.Drawing.Color.Red;
            this.LabelPasswortVorgabenZ.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortVorgabenZ.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortVorgabenZ.Location = new System.Drawing.Point(497, 169);
            this.LabelPasswortVorgabenZ.Name = "LabelPasswortVorgabenZ";
            this.LabelPasswortVorgabenZ.Size = new System.Drawing.Size(307, 85);
            this.LabelPasswortVorgabenZ.TabIndex = 6;
            this.LabelPasswortVorgabenZ.Text = ">Passwort muss mindestens 8 Zeichen lang sein\r\n   einen Großbuchstaben, \r\n   eine" +
    "n Kleinbuchstaben, \r\n   eine Zahl und \r\n   ein Sonderzeichen enthalten.\r\n";
            this.LabelPasswortVorgabenZ.Visible = false;
            // 
            // LabelPasswortFehlerZ
            // 
            this.LabelPasswortFehlerZ.AutoSize = true;
            this.LabelPasswortFehlerZ.BackColor = System.Drawing.Color.Red;
            this.LabelPasswortFehlerZ.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortFehlerZ.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortFehlerZ.Location = new System.Drawing.Point(497, 251);
            this.LabelPasswortFehlerZ.Name = "LabelPasswortFehlerZ";
            this.LabelPasswortFehlerZ.Size = new System.Drawing.Size(227, 17);
            this.LabelPasswortFehlerZ.TabIndex = 7;
            this.LabelPasswortFehlerZ.Text = ">Passwörter stimmen nicht überein";
            this.LabelPasswortFehlerZ.Visible = false;
            // 
            // PasswortZurücksetzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelPasswortFehlerZ);
            this.Controls.Add(this.LabelPasswortVorgabenZ);
            this.Controls.Add(this.ButtonZurückPWZ);
            this.Controls.Add(this.ButtonBestätigenPWZ);
            this.Controls.Add(this.TextboxPWZwiederholen);
            this.Controls.Add(this.LabelPwWiederholen);
            this.Controls.Add(this.TextboxPwZurücksetzen);
            this.Controls.Add(this.LabelPwZurücksetzen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswortZurücksetzen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswortZurücksetzen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswortZurücksetzen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPwZurücksetzen;
        private System.Windows.Forms.TextBox TextboxPwZurücksetzen;
        private System.Windows.Forms.Label LabelPwWiederholen;
        private System.Windows.Forms.TextBox TextboxPWZwiederholen;
        private System.Windows.Forms.Button ButtonBestätigenPWZ;
        private System.Windows.Forms.Button ButtonZurückPWZ;
        private System.Windows.Forms.Label LabelPasswortVorgabenZ;
        private System.Windows.Forms.Label LabelPasswortFehlerZ;
    }
}