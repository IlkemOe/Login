namespace Login.Forms
{
    partial class BearbeitenBenutzer
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
            this.ButtonZurückR = new System.Windows.Forms.Button();
            this.LabelSicherheitsfrageGrund = new System.Windows.Forms.Label();
            this.TextboxSicherheitsantwort = new System.Windows.Forms.TextBox();
            this.ComboboxSicherheitsfrage = new System.Windows.Forms.ComboBox();
            this.LabelSicherheitsfrage = new System.Windows.Forms.Label();
            this.LabelEmailFormat = new System.Windows.Forms.Label();
            this.LabelVorname = new System.Windows.Forms.Label();
            this.TextboxVorname = new System.Windows.Forms.TextBox();
            this.LabelPasswortVorgaben = new System.Windows.Forms.Label();
            this.LabelNachname = new System.Windows.Forms.Label();
            this.LabelPasswortFehler = new System.Windows.Forms.Label();
            this.TextboxNachname = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.ButtonÜberschreiben = new System.Windows.Forms.Button();
            this.TextboxEmail = new System.Windows.Forms.TextBox();
            this.TextboxPasswortWiederholen = new System.Windows.Forms.TextBox();
            this.LabelBenutzername = new System.Windows.Forms.Label();
            this.LabelPasswortWiederholen = new System.Windows.Forms.Label();
            this.TextboxBenutzername = new System.Windows.Forms.TextBox();
            this.TextboxPasswort = new System.Windows.Forms.TextBox();
            this.LabelPasswortR = new System.Windows.Forms.Label();
            this.ButtonFragezeichen = new System.Windows.Forms.Button();
            this.CheckboxStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonZurückR
            // 
            this.ButtonZurückR.BackColor = System.Drawing.Color.Gray;
            this.ButtonZurückR.FlatAppearance.BorderSize = 0;
            this.ButtonZurückR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZurückR.Image = global::Login.Properties.Resources.circle_back;
            this.ButtonZurückR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonZurückR.Location = new System.Drawing.Point(58, 58);
            this.ButtonZurückR.Name = "ButtonZurückR";
            this.ButtonZurückR.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonZurückR.Size = new System.Drawing.Size(65, 33);
            this.ButtonZurückR.TabIndex = 58;
            this.ButtonZurückR.UseVisualStyleBackColor = false;
            // 
            // LabelSicherheitsfrageGrund
            // 
            this.LabelSicherheitsfrageGrund.AutoSize = true;
            this.LabelSicherheitsfrageGrund.BackColor = System.Drawing.Color.Red;
            this.LabelSicherheitsfrageGrund.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSicherheitsfrageGrund.ForeColor = System.Drawing.Color.White;
            this.LabelSicherheitsfrageGrund.Location = new System.Drawing.Point(624, 475);
            this.LabelSicherheitsfrageGrund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSicherheitsfrageGrund.Name = "LabelSicherheitsfrageGrund";
            this.LabelSicherheitsfrageGrund.Size = new System.Drawing.Size(267, 34);
            this.LabelSicherheitsfrageGrund.TabIndex = 57;
            this.LabelSicherheitsfrageGrund.Text = "Die Sicherheitsfrage wird abgefragt wenn\r\nSie Ihr Passwort vergessen haben";
            this.LabelSicherheitsfrageGrund.Visible = false;
            // 
            // TextboxSicherheitsantwort
            // 
            this.TextboxSicherheitsantwort.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxSicherheitsantwort.ForeColor = System.Drawing.Color.Gray;
            this.TextboxSicherheitsantwort.Location = new System.Drawing.Point(300, 512);
            this.TextboxSicherheitsantwort.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxSicherheitsantwort.Name = "TextboxSicherheitsantwort";
            this.TextboxSicherheitsantwort.Size = new System.Drawing.Size(273, 29);
            this.TextboxSicherheitsantwort.TabIndex = 56;
            // 
            // ComboboxSicherheitsfrage
            // 
            this.ComboboxSicherheitsfrage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxSicherheitsfrage.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxSicherheitsfrage.ForeColor = System.Drawing.Color.MediumBlue;
            this.ComboboxSicherheitsfrage.FormattingEnabled = true;
            this.ComboboxSicherheitsfrage.Items.AddRange(new object[] {
            "Wie hieß Ihr Lieblingslehrer?",
            "Wie heißt Ihr Lieblingsfilm?",
            "Was war Ihr erstes Auto?",
            "Wo sind Sie aufgewachsen?"});
            this.ComboboxSicherheitsfrage.Location = new System.Drawing.Point(300, 475);
            this.ComboboxSicherheitsfrage.Margin = new System.Windows.Forms.Padding(4);
            this.ComboboxSicherheitsfrage.Name = "ComboboxSicherheitsfrage";
            this.ComboboxSicherheitsfrage.Size = new System.Drawing.Size(273, 30);
            this.ComboboxSicherheitsfrage.TabIndex = 55;
            // 
            // LabelSicherheitsfrage
            // 
            this.LabelSicherheitsfrage.AutoSize = true;
            this.LabelSicherheitsfrage.BackColor = System.Drawing.Color.Transparent;
            this.LabelSicherheitsfrage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSicherheitsfrage.ForeColor = System.Drawing.Color.Gray;
            this.LabelSicherheitsfrage.Location = new System.Drawing.Point(296, 457);
            this.LabelSicherheitsfrage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSicherheitsfrage.Name = "LabelSicherheitsfrage";
            this.LabelSicherheitsfrage.Size = new System.Drawing.Size(109, 17);
            this.LabelSicherheitsfrage.TabIndex = 54;
            this.LabelSicherheitsfrage.Text = "Sicherheitsfrage";
            // 
            // LabelEmailFormat
            // 
            this.LabelEmailFormat.AutoSize = true;
            this.LabelEmailFormat.BackColor = System.Drawing.Color.Red;
            this.LabelEmailFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailFormat.ForeColor = System.Drawing.Color.White;
            this.LabelEmailFormat.Location = new System.Drawing.Point(581, 204);
            this.LabelEmailFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmailFormat.Name = "LabelEmailFormat";
            this.LabelEmailFormat.Size = new System.Drawing.Size(194, 34);
            this.LabelEmailFormat.TabIndex = 53;
            this.LabelEmailFormat.Text = "Die E-Mail Adresse entspricht\r\n keinem gültigen Format\r\n";
            this.LabelEmailFormat.Visible = false;
            // 
            // LabelVorname
            // 
            this.LabelVorname.AutoSize = true;
            this.LabelVorname.BackColor = System.Drawing.Color.Transparent;
            this.LabelVorname.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVorname.ForeColor = System.Drawing.Color.Gray;
            this.LabelVorname.Location = new System.Drawing.Point(297, 58);
            this.LabelVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelVorname.Name = "LabelVorname";
            this.LabelVorname.Size = new System.Drawing.Size(65, 17);
            this.LabelVorname.TabIndex = 38;
            this.LabelVorname.Text = "Vorname";
            // 
            // TextboxVorname
            // 
            this.TextboxVorname.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxVorname.ForeColor = System.Drawing.Color.Black;
            this.TextboxVorname.Location = new System.Drawing.Point(300, 78);
            this.TextboxVorname.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxVorname.Name = "TextboxVorname";
            this.TextboxVorname.Size = new System.Drawing.Size(273, 29);
            this.TextboxVorname.TabIndex = 39;
            // 
            // LabelPasswortVorgaben
            // 
            this.LabelPasswortVorgaben.AutoSize = true;
            this.LabelPasswortVorgaben.BackColor = System.Drawing.Color.Red;
            this.LabelPasswortVorgaben.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortVorgaben.Location = new System.Drawing.Point(581, 334);
            this.LabelPasswortVorgaben.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPasswortVorgaben.Name = "LabelPasswortVorgaben";
            this.LabelPasswortVorgaben.Size = new System.Drawing.Size(229, 65);
            this.LabelPasswortVorgaben.TabIndex = 52;
            this.LabelPasswortVorgaben.Text = "Passwort muss mindestens 8 Zeichen lang sein\r\n   einen Großbuchstaben, \r\n   einen" +
    " Kleinbuchstaben, \r\n   eine Zahl und \r\n   ein Sonderzeichen enthalten.";
            this.LabelPasswortVorgaben.Visible = false;
            // 
            // LabelNachname
            // 
            this.LabelNachname.AutoSize = true;
            this.LabelNachname.BackColor = System.Drawing.Color.Transparent;
            this.LabelNachname.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNachname.ForeColor = System.Drawing.Color.Gray;
            this.LabelNachname.Location = new System.Drawing.Point(296, 123);
            this.LabelNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNachname.Name = "LabelNachname";
            this.LabelNachname.Size = new System.Drawing.Size(76, 17);
            this.LabelNachname.TabIndex = 40;
            this.LabelNachname.Text = "Nachname";
            // 
            // LabelPasswortFehler
            // 
            this.LabelPasswortFehler.AutoSize = true;
            this.LabelPasswortFehler.BackColor = System.Drawing.Color.Red;
            this.LabelPasswortFehler.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortFehler.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortFehler.Location = new System.Drawing.Point(300, 420);
            this.LabelPasswortFehler.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPasswortFehler.Name = "LabelPasswortFehler";
            this.LabelPasswortFehler.Size = new System.Drawing.Size(224, 17);
            this.LabelPasswortFehler.TabIndex = 51;
            this.LabelPasswortFehler.Text = "Passwörter stimmen nicht überein!";
            this.LabelPasswortFehler.Visible = false;
            // 
            // TextboxNachname
            // 
            this.TextboxNachname.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxNachname.ForeColor = System.Drawing.Color.Black;
            this.TextboxNachname.Location = new System.Drawing.Point(300, 140);
            this.TextboxNachname.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxNachname.Name = "TextboxNachname";
            this.TextboxNachname.Size = new System.Drawing.Size(273, 29);
            this.TextboxNachname.TabIndex = 41;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.Color.Gray;
            this.LabelEmail.Location = new System.Drawing.Point(296, 187);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(46, 17);
            this.LabelEmail.TabIndex = 42;
            this.LabelEmail.Text = "E-Mail";
            // 
            // ButtonÜberschreiben
            // 
            this.ButtonÜberschreiben.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonÜberschreiben.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonÜberschreiben.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonÜberschreiben.ForeColor = System.Drawing.Color.White;
            this.ButtonÜberschreiben.Location = new System.Drawing.Point(353, 575);
            this.ButtonÜberschreiben.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonÜberschreiben.Name = "ButtonÜberschreiben";
            this.ButtonÜberschreiben.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonÜberschreiben.Size = new System.Drawing.Size(171, 41);
            this.ButtonÜberschreiben.TabIndex = 50;
            this.ButtonÜberschreiben.Text = "Überschreiben";
            this.ButtonÜberschreiben.UseVisualStyleBackColor = false;
            this.ButtonÜberschreiben.Click += new System.EventHandler(this.ButtonÜberschreiben_Click);
            // 
            // TextboxEmail
            // 
            this.TextboxEmail.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxEmail.ForeColor = System.Drawing.Color.Black;
            this.TextboxEmail.Location = new System.Drawing.Point(300, 204);
            this.TextboxEmail.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxEmail.Name = "TextboxEmail";
            this.TextboxEmail.Size = new System.Drawing.Size(273, 29);
            this.TextboxEmail.TabIndex = 43;
            // 
            // TextboxPasswortWiederholen
            // 
            this.TextboxPasswortWiederholen.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxPasswortWiederholen.ForeColor = System.Drawing.Color.Black;
            this.TextboxPasswortWiederholen.Location = new System.Drawing.Point(300, 391);
            this.TextboxPasswortWiederholen.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxPasswortWiederholen.Name = "TextboxPasswortWiederholen";
            this.TextboxPasswortWiederholen.Size = new System.Drawing.Size(273, 29);
            this.TextboxPasswortWiederholen.TabIndex = 49;
            // 
            // LabelBenutzername
            // 
            this.LabelBenutzername.AutoSize = true;
            this.LabelBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.LabelBenutzername.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBenutzername.ForeColor = System.Drawing.Color.Gray;
            this.LabelBenutzername.Location = new System.Drawing.Point(296, 254);
            this.LabelBenutzername.Margin = new System.Windows.Forms.Padding(0);
            this.LabelBenutzername.Name = "LabelBenutzername";
            this.LabelBenutzername.Size = new System.Drawing.Size(99, 17);
            this.LabelBenutzername.TabIndex = 44;
            this.LabelBenutzername.Text = "Benutzername";
            this.LabelBenutzername.UseWaitCursor = true;
            // 
            // LabelPasswortWiederholen
            // 
            this.LabelPasswortWiederholen.AutoSize = true;
            this.LabelPasswortWiederholen.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswortWiederholen.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortWiederholen.ForeColor = System.Drawing.Color.Gray;
            this.LabelPasswortWiederholen.Location = new System.Drawing.Point(296, 373);
            this.LabelPasswortWiederholen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPasswortWiederholen.Name = "LabelPasswortWiederholen";
            this.LabelPasswortWiederholen.Size = new System.Drawing.Size(146, 17);
            this.LabelPasswortWiederholen.TabIndex = 48;
            this.LabelPasswortWiederholen.Text = "Passwort wiederholen";
            // 
            // TextboxBenutzername
            // 
            this.TextboxBenutzername.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxBenutzername.ForeColor = System.Drawing.Color.Black;
            this.TextboxBenutzername.Location = new System.Drawing.Point(300, 271);
            this.TextboxBenutzername.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxBenutzername.Name = "TextboxBenutzername";
            this.TextboxBenutzername.Size = new System.Drawing.Size(273, 29);
            this.TextboxBenutzername.TabIndex = 45;
            // 
            // TextboxPasswort
            // 
            this.TextboxPasswort.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxPasswort.ForeColor = System.Drawing.Color.Black;
            this.TextboxPasswort.Location = new System.Drawing.Point(300, 334);
            this.TextboxPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPasswort.Name = "TextboxPasswort";
            this.TextboxPasswort.Size = new System.Drawing.Size(273, 29);
            this.TextboxPasswort.TabIndex = 47;
            // 
            // LabelPasswortR
            // 
            this.LabelPasswortR.AutoSize = true;
            this.LabelPasswortR.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswortR.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortR.ForeColor = System.Drawing.Color.Gray;
            this.LabelPasswortR.Location = new System.Drawing.Point(296, 313);
            this.LabelPasswortR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPasswortR.Name = "LabelPasswortR";
            this.LabelPasswortR.Size = new System.Drawing.Size(68, 17);
            this.LabelPasswortR.TabIndex = 46;
            this.LabelPasswortR.Text = "Passwort";
            // 
            // ButtonFragezeichen
            // 
            this.ButtonFragezeichen.BackColor = System.Drawing.Color.Silver;
            this.ButtonFragezeichen.FlatAppearance.BorderSize = 0;
            this.ButtonFragezeichen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFragezeichen.Font = new System.Drawing.Font("Roboto", 10F);
            this.ButtonFragezeichen.ForeColor = System.Drawing.Color.White;
            this.ButtonFragezeichen.Location = new System.Drawing.Point(580, 475);
            this.ButtonFragezeichen.Name = "ButtonFragezeichen";
            this.ButtonFragezeichen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonFragezeichen.Size = new System.Drawing.Size(37, 30);
            this.ButtonFragezeichen.TabIndex = 59;
            this.ButtonFragezeichen.Text = "?";
            this.ButtonFragezeichen.UseVisualStyleBackColor = false;
            // 
            // CheckboxStatus
            // 
            this.CheckboxStatus.AutoSize = true;
            this.CheckboxStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxStatus.Location = new System.Drawing.Point(299, 548);
            this.CheckboxStatus.Name = "CheckboxStatus";
            this.CheckboxStatus.Size = new System.Drawing.Size(249, 23);
            this.CheckboxStatus.TabIndex = 61;
            this.CheckboxStatus.Text = "Benutzer als Admin hinzufügen";
            this.CheckboxStatus.UseVisualStyleBackColor = true;
            // 
            // BearbeitenBenutzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 645);
            this.Controls.Add(this.CheckboxStatus);
            this.Controls.Add(this.ButtonZurückR);
            this.Controls.Add(this.LabelSicherheitsfrageGrund);
            this.Controls.Add(this.TextboxSicherheitsantwort);
            this.Controls.Add(this.ComboboxSicherheitsfrage);
            this.Controls.Add(this.LabelSicherheitsfrage);
            this.Controls.Add(this.LabelEmailFormat);
            this.Controls.Add(this.LabelVorname);
            this.Controls.Add(this.TextboxVorname);
            this.Controls.Add(this.LabelPasswortVorgaben);
            this.Controls.Add(this.LabelNachname);
            this.Controls.Add(this.LabelPasswortFehler);
            this.Controls.Add(this.TextboxNachname);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.ButtonÜberschreiben);
            this.Controls.Add(this.TextboxEmail);
            this.Controls.Add(this.TextboxPasswortWiederholen);
            this.Controls.Add(this.LabelBenutzername);
            this.Controls.Add(this.LabelPasswortWiederholen);
            this.Controls.Add(this.TextboxBenutzername);
            this.Controls.Add(this.TextboxPasswort);
            this.Controls.Add(this.LabelPasswortR);
            this.Controls.Add(this.ButtonFragezeichen);
            this.Name = "BearbeitenBenutzer";
            this.Text = "DatenBearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonZurückR;
        private System.Windows.Forms.Label LabelSicherheitsfrageGrund;
        private System.Windows.Forms.TextBox TextboxSicherheitsantwort;
        private System.Windows.Forms.ComboBox ComboboxSicherheitsfrage;
        private System.Windows.Forms.Label LabelSicherheitsfrage;
        private System.Windows.Forms.Label LabelEmailFormat;
        private System.Windows.Forms.Label LabelVorname;
        private System.Windows.Forms.TextBox TextboxVorname;
        private System.Windows.Forms.Label LabelPasswortVorgaben;
        private System.Windows.Forms.Label LabelNachname;
        private System.Windows.Forms.Label LabelPasswortFehler;
        private System.Windows.Forms.TextBox TextboxNachname;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Button ButtonÜberschreiben;
        private System.Windows.Forms.TextBox TextboxEmail;
        private System.Windows.Forms.TextBox TextboxPasswortWiederholen;
        private System.Windows.Forms.Label LabelBenutzername;
        private System.Windows.Forms.Label LabelPasswortWiederholen;
        private System.Windows.Forms.TextBox TextboxBenutzername;
        private System.Windows.Forms.TextBox TextboxPasswort;
        private System.Windows.Forms.Label LabelPasswortR;
        private System.Windows.Forms.Button ButtonFragezeichen;
        private System.Windows.Forms.CheckBox CheckboxStatus;
    }
}