namespace Login.Forms
{
    partial class NeuenBenutzerHinzufügen
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
            this.ButtonZurückNeu = new System.Windows.Forms.Button();
            this.LabelSicherheitsfrageGrund = new System.Windows.Forms.Label();
            this.TextboxSicherheitsantwortNeu = new System.Windows.Forms.TextBox();
            this.ComboboxSicherheitsfrage = new System.Windows.Forms.ComboBox();
            this.LabelSicherheitsfrage = new System.Windows.Forms.Label();
            this.LabelEmailFormat = new System.Windows.Forms.Label();
            this.LabelVorname = new System.Windows.Forms.Label();
            this.TextboxVornameNeu = new System.Windows.Forms.TextBox();
            this.LabelPasswortVorgaben = new System.Windows.Forms.Label();
            this.LabelNachname = new System.Windows.Forms.Label();
            this.LabelPasswortFehler = new System.Windows.Forms.Label();
            this.TextboxNachnameNeu = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.ButtonJetztRegistrierenNeu = new System.Windows.Forms.Button();
            this.TextboxEmailNeu = new System.Windows.Forms.TextBox();
            this.TextboxPasswortWiederholenNeu = new System.Windows.Forms.TextBox();
            this.LabelBenutzername = new System.Windows.Forms.Label();
            this.LabelPasswortWiederholen = new System.Windows.Forms.Label();
            this.TextboxBenutzernameNeu = new System.Windows.Forms.TextBox();
            this.TextboxPasswortNeu = new System.Windows.Forms.TextBox();
            this.LabelPasswortR = new System.Windows.Forms.Label();
            this.ButtonFragezeichen = new System.Windows.Forms.Button();
            this.CheckboxAlsAdminHinzufügen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonZurückNeu
            // 
            this.ButtonZurückNeu.BackColor = System.Drawing.Color.Gray;
            this.ButtonZurückNeu.FlatAppearance.BorderSize = 0;
            this.ButtonZurückNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZurückNeu.Image = global::Login.Properties.Resources.circle_back;
            this.ButtonZurückNeu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonZurückNeu.Location = new System.Drawing.Point(17, 18);
            this.ButtonZurückNeu.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonZurückNeu.Name = "ButtonZurückNeu";
            this.ButtonZurückNeu.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.ButtonZurückNeu.Size = new System.Drawing.Size(87, 41);
            this.ButtonZurückNeu.TabIndex = 58;
            this.ButtonZurückNeu.UseVisualStyleBackColor = false;
            this.ButtonZurückNeu.Click += new System.EventHandler(this.ButtonZurückR_Click);
            // 
            // LabelSicherheitsfrageGrund
            // 
            this.LabelSicherheitsfrageGrund.AutoSize = true;
            this.LabelSicherheitsfrageGrund.BackColor = System.Drawing.Color.Red;
            this.LabelSicherheitsfrageGrund.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSicherheitsfrageGrund.ForeColor = System.Drawing.Color.White;
            this.LabelSicherheitsfrageGrund.Location = new System.Drawing.Point(812, 532);
            this.LabelSicherheitsfrageGrund.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSicherheitsfrageGrund.Name = "LabelSicherheitsfrageGrund";
            this.LabelSicherheitsfrageGrund.Size = new System.Drawing.Size(317, 40);
            this.LabelSicherheitsfrageGrund.TabIndex = 57;
            this.LabelSicherheitsfrageGrund.Text = "Die Sicherheitsfrage wird abgefragt wenn\r\nSie Ihr Passwort vergessen haben";
            this.LabelSicherheitsfrageGrund.Visible = false;
            // 
            // TextboxSicherheitsantwortNeu
            // 
            this.TextboxSicherheitsantwortNeu.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxSicherheitsantwortNeu.ForeColor = System.Drawing.Color.Gray;
            this.TextboxSicherheitsantwortNeu.Location = new System.Drawing.Point(380, 577);
            this.TextboxSicherheitsantwortNeu.Margin = new System.Windows.Forms.Padding(5);
            this.TextboxSicherheitsantwortNeu.Name = "TextboxSicherheitsantwortNeu";
            this.TextboxSicherheitsantwortNeu.Size = new System.Drawing.Size(363, 34);
            this.TextboxSicherheitsantwortNeu.TabIndex = 56;
            this.TextboxSicherheitsantwortNeu.TextChanged += new System.EventHandler(this.TextboxSicherheitsfrage_TextChanged);
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
            this.ComboboxSicherheitsfrage.Location = new System.Drawing.Point(380, 532);
            this.ComboboxSicherheitsfrage.Margin = new System.Windows.Forms.Padding(5);
            this.ComboboxSicherheitsfrage.Name = "ComboboxSicherheitsfrage";
            this.ComboboxSicherheitsfrage.Size = new System.Drawing.Size(363, 35);
            this.ComboboxSicherheitsfrage.TabIndex = 55;
            // 
            // LabelSicherheitsfrage
            // 
            this.LabelSicherheitsfrage.AutoSize = true;
            this.LabelSicherheitsfrage.BackColor = System.Drawing.Color.Transparent;
            this.LabelSicherheitsfrage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSicherheitsfrage.ForeColor = System.Drawing.Color.Gray;
            this.LabelSicherheitsfrage.Location = new System.Drawing.Point(375, 510);
            this.LabelSicherheitsfrage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSicherheitsfrage.Name = "LabelSicherheitsfrage";
            this.LabelSicherheitsfrage.Size = new System.Drawing.Size(133, 20);
            this.LabelSicherheitsfrage.TabIndex = 54;
            this.LabelSicherheitsfrage.Text = "Sicherheitsfrage";
            // 
            // LabelEmailFormat
            // 
            this.LabelEmailFormat.AutoSize = true;
            this.LabelEmailFormat.BackColor = System.Drawing.Color.Red;
            this.LabelEmailFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailFormat.ForeColor = System.Drawing.Color.White;
            this.LabelEmailFormat.Location = new System.Drawing.Point(755, 198);
            this.LabelEmailFormat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelEmailFormat.Name = "LabelEmailFormat";
            this.LabelEmailFormat.Size = new System.Drawing.Size(234, 40);
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
            this.LabelVorname.Location = new System.Drawing.Point(376, 18);
            this.LabelVorname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelVorname.Name = "LabelVorname";
            this.LabelVorname.Size = new System.Drawing.Size(78, 20);
            this.LabelVorname.TabIndex = 38;
            this.LabelVorname.Text = "Vorname";
            // 
            // TextboxVornameNeu
            // 
            this.TextboxVornameNeu.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxVornameNeu.ForeColor = System.Drawing.Color.Black;
            this.TextboxVornameNeu.Location = new System.Drawing.Point(380, 43);
            this.TextboxVornameNeu.Margin = new System.Windows.Forms.Padding(5);
            this.TextboxVornameNeu.Name = "TextboxVornameNeu";
            this.TextboxVornameNeu.Size = new System.Drawing.Size(363, 34);
            this.TextboxVornameNeu.TabIndex = 39;
            this.TextboxVornameNeu.TextChanged += new System.EventHandler(this.TextboxVorname_TextChanged);
            // 
            // LabelPasswortVorgaben
            // 
            this.LabelPasswortVorgaben.AutoSize = true;
            this.LabelPasswortVorgaben.BackColor = System.Drawing.Color.Red;
            this.LabelPasswortVorgaben.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortVorgaben.Location = new System.Drawing.Point(755, 358);
            this.LabelPasswortVorgaben.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPasswortVorgaben.Name = "LabelPasswortVorgaben";
            this.LabelPasswortVorgaben.Size = new System.Drawing.Size(287, 80);
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
            this.LabelNachname.Location = new System.Drawing.Point(375, 98);
            this.LabelNachname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelNachname.Name = "LabelNachname";
            this.LabelNachname.Size = new System.Drawing.Size(90, 20);
            this.LabelNachname.TabIndex = 40;
            this.LabelNachname.Text = "Nachname";
            // 
            // LabelPasswortFehler
            // 
            this.LabelPasswortFehler.AutoSize = true;
            this.LabelPasswortFehler.BackColor = System.Drawing.Color.Red;
            this.LabelPasswortFehler.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortFehler.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortFehler.Location = new System.Drawing.Point(380, 464);
            this.LabelPasswortFehler.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPasswortFehler.Name = "LabelPasswortFehler";
            this.LabelPasswortFehler.Size = new System.Drawing.Size(273, 20);
            this.LabelPasswortFehler.TabIndex = 51;
            this.LabelPasswortFehler.Text = "Passwörter stimmen nicht überein!";
            this.LabelPasswortFehler.Visible = false;
            // 
            // TextboxNachnameNeu
            // 
            this.TextboxNachnameNeu.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxNachnameNeu.ForeColor = System.Drawing.Color.Black;
            this.TextboxNachnameNeu.Location = new System.Drawing.Point(380, 119);
            this.TextboxNachnameNeu.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxNachnameNeu.Name = "TextboxNachnameNeu";
            this.TextboxNachnameNeu.Size = new System.Drawing.Size(363, 34);
            this.TextboxNachnameNeu.TabIndex = 41;
            this.TextboxNachnameNeu.TextChanged += new System.EventHandler(this.TextboxNachname_TextChanged);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.Color.Gray;
            this.LabelEmail.Location = new System.Drawing.Point(375, 177);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(56, 20);
            this.LabelEmail.TabIndex = 42;
            this.LabelEmail.Text = "E-Mail";
            // 
            // ButtonJetztRegistrierenNeu
            // 
            this.ButtonJetztRegistrierenNeu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonJetztRegistrierenNeu.Enabled = false;
            this.ButtonJetztRegistrierenNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonJetztRegistrierenNeu.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonJetztRegistrierenNeu.ForeColor = System.Drawing.Color.White;
            this.ButtonJetztRegistrierenNeu.Location = new System.Drawing.Point(451, 667);
            this.ButtonJetztRegistrierenNeu.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonJetztRegistrierenNeu.Name = "ButtonJetztRegistrierenNeu";
            this.ButtonJetztRegistrierenNeu.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.ButtonJetztRegistrierenNeu.Size = new System.Drawing.Size(228, 50);
            this.ButtonJetztRegistrierenNeu.TabIndex = 50;
            this.ButtonJetztRegistrierenNeu.Text = "Jetzt Registrieren";
            this.ButtonJetztRegistrierenNeu.UseVisualStyleBackColor = false;
            this.ButtonJetztRegistrierenNeu.Click += new System.EventHandler(this.ButtonJetztRegistrieren_Click);
            this.ButtonJetztRegistrierenNeu.MouseLeave += new System.EventHandler(this.ButtonJetztRegistrieren_MouseLeave);
            this.ButtonJetztRegistrierenNeu.MouseHover += new System.EventHandler(this.ButtonJetztRegistrieren_MouseHover);
            // 
            // TextboxEmailNeu
            // 
            this.TextboxEmailNeu.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxEmailNeu.ForeColor = System.Drawing.Color.Black;
            this.TextboxEmailNeu.Location = new System.Drawing.Point(380, 198);
            this.TextboxEmailNeu.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxEmailNeu.Name = "TextboxEmailNeu";
            this.TextboxEmailNeu.Size = new System.Drawing.Size(363, 34);
            this.TextboxEmailNeu.TabIndex = 43;
            this.TextboxEmailNeu.TextChanged += new System.EventHandler(this.TextboxEmail_TextChanged);
            // 
            // TextboxPasswortWiederholenNeu
            // 
            this.TextboxPasswortWiederholenNeu.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxPasswortWiederholenNeu.ForeColor = System.Drawing.Color.Black;
            this.TextboxPasswortWiederholenNeu.Location = new System.Drawing.Point(380, 428);
            this.TextboxPasswortWiederholenNeu.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxPasswortWiederholenNeu.Name = "TextboxPasswortWiederholenNeu";
            this.TextboxPasswortWiederholenNeu.Size = new System.Drawing.Size(363, 34);
            this.TextboxPasswortWiederholenNeu.TabIndex = 49;
            this.TextboxPasswortWiederholenNeu.TextChanged += new System.EventHandler(this.TextboxPasswortWiederholen_TextChanged);
            this.TextboxPasswortWiederholenNeu.Leave += new System.EventHandler(this.TextboxPasswortWiederholen_Leave);
            // 
            // LabelBenutzername
            // 
            this.LabelBenutzername.AutoSize = true;
            this.LabelBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.LabelBenutzername.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBenutzername.ForeColor = System.Drawing.Color.Gray;
            this.LabelBenutzername.Location = new System.Drawing.Point(375, 260);
            this.LabelBenutzername.Margin = new System.Windows.Forms.Padding(0);
            this.LabelBenutzername.Name = "LabelBenutzername";
            this.LabelBenutzername.Size = new System.Drawing.Size(118, 20);
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
            this.LabelPasswortWiederholen.Location = new System.Drawing.Point(375, 406);
            this.LabelPasswortWiederholen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPasswortWiederholen.Name = "LabelPasswortWiederholen";
            this.LabelPasswortWiederholen.Size = new System.Drawing.Size(178, 20);
            this.LabelPasswortWiederholen.TabIndex = 48;
            this.LabelPasswortWiederholen.Text = "Passwort wiederholen";
            // 
            // TextboxBenutzernameNeu
            // 
            this.TextboxBenutzernameNeu.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxBenutzernameNeu.ForeColor = System.Drawing.Color.Black;
            this.TextboxBenutzernameNeu.Location = new System.Drawing.Point(380, 281);
            this.TextboxBenutzernameNeu.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxBenutzernameNeu.Name = "TextboxBenutzernameNeu";
            this.TextboxBenutzernameNeu.Size = new System.Drawing.Size(363, 34);
            this.TextboxBenutzernameNeu.TabIndex = 45;
            this.TextboxBenutzernameNeu.TextChanged += new System.EventHandler(this.TextboxBenutzername_TextChanged);
            // 
            // TextboxPasswortNeu
            // 
            this.TextboxPasswortNeu.Font = new System.Drawing.Font("Roboto", 13.2F);
            this.TextboxPasswortNeu.ForeColor = System.Drawing.Color.Black;
            this.TextboxPasswortNeu.Location = new System.Drawing.Point(380, 358);
            this.TextboxPasswortNeu.Margin = new System.Windows.Forms.Padding(5);
            this.TextboxPasswortNeu.Name = "TextboxPasswortNeu";
            this.TextboxPasswortNeu.Size = new System.Drawing.Size(363, 34);
            this.TextboxPasswortNeu.TabIndex = 47;
            this.TextboxPasswortNeu.TextChanged += new System.EventHandler(this.TextboxPasswortR_TextChanged);
            this.TextboxPasswortNeu.Leave += new System.EventHandler(this.TextboxPasswortR_Leave);
            // 
            // LabelPasswortR
            // 
            this.LabelPasswortR.AutoSize = true;
            this.LabelPasswortR.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswortR.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswortR.ForeColor = System.Drawing.Color.Gray;
            this.LabelPasswortR.Location = new System.Drawing.Point(375, 332);
            this.LabelPasswortR.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPasswortR.Name = "LabelPasswortR";
            this.LabelPasswortR.Size = new System.Drawing.Size(82, 20);
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
            this.ButtonFragezeichen.Location = new System.Drawing.Point(753, 532);
            this.ButtonFragezeichen.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFragezeichen.Name = "ButtonFragezeichen";
            this.ButtonFragezeichen.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.ButtonFragezeichen.Size = new System.Drawing.Size(49, 37);
            this.ButtonFragezeichen.TabIndex = 59;
            this.ButtonFragezeichen.Text = "?";
            this.ButtonFragezeichen.UseVisualStyleBackColor = false;
            this.ButtonFragezeichen.MouseLeave += new System.EventHandler(this.PictureboxFragezeichen_MouseLeave);
            this.ButtonFragezeichen.MouseHover += new System.EventHandler(this.PictureboxFragezeichen_MouseHover);
            // 
            // CheckboxAlsAdminHinzufügen
            // 
            this.CheckboxAlsAdminHinzufügen.AutoSize = true;
            this.CheckboxAlsAdminHinzufügen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxAlsAdminHinzufügen.Location = new System.Drawing.Point(380, 622);
            this.CheckboxAlsAdminHinzufügen.Margin = new System.Windows.Forms.Padding(4);
            this.CheckboxAlsAdminHinzufügen.Name = "CheckboxAlsAdminHinzufügen";
            this.CheckboxAlsAdminHinzufügen.Size = new System.Drawing.Size(310, 28);
            this.CheckboxAlsAdminHinzufügen.TabIndex = 60;
            this.CheckboxAlsAdminHinzufügen.Text = "Benutzer als Admin hinzufügen";
            this.CheckboxAlsAdminHinzufügen.UseVisualStyleBackColor = true;
            // 
            // NeuenBenutzerHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 746);
            this.Controls.Add(this.CheckboxAlsAdminHinzufügen);
            this.Controls.Add(this.ButtonZurückNeu);
            this.Controls.Add(this.LabelSicherheitsfrageGrund);
            this.Controls.Add(this.TextboxSicherheitsantwortNeu);
            this.Controls.Add(this.ComboboxSicherheitsfrage);
            this.Controls.Add(this.LabelSicherheitsfrage);
            this.Controls.Add(this.LabelEmailFormat);
            this.Controls.Add(this.LabelVorname);
            this.Controls.Add(this.TextboxVornameNeu);
            this.Controls.Add(this.LabelPasswortVorgaben);
            this.Controls.Add(this.LabelNachname);
            this.Controls.Add(this.LabelPasswortFehler);
            this.Controls.Add(this.TextboxNachnameNeu);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.ButtonJetztRegistrierenNeu);
            this.Controls.Add(this.TextboxEmailNeu);
            this.Controls.Add(this.TextboxPasswortWiederholenNeu);
            this.Controls.Add(this.LabelBenutzername);
            this.Controls.Add(this.LabelPasswortWiederholen);
            this.Controls.Add(this.TextboxBenutzernameNeu);
            this.Controls.Add(this.TextboxPasswortNeu);
            this.Controls.Add(this.LabelPasswortR);
            this.Controls.Add(this.ButtonFragezeichen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NeuenBenutzerHinzufügen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeuenBenutzerHinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonZurückNeu;
        private System.Windows.Forms.Label LabelSicherheitsfrageGrund;
        private System.Windows.Forms.TextBox TextboxSicherheitsantwortNeu;
        private System.Windows.Forms.ComboBox ComboboxSicherheitsfrage;
        private System.Windows.Forms.Label LabelSicherheitsfrage;
        private System.Windows.Forms.Label LabelEmailFormat;
        private System.Windows.Forms.Label LabelVorname;
        private System.Windows.Forms.TextBox TextboxVornameNeu;
        private System.Windows.Forms.Label LabelPasswortVorgaben;
        private System.Windows.Forms.Label LabelNachname;
        private System.Windows.Forms.Label LabelPasswortFehler;
        private System.Windows.Forms.TextBox TextboxNachnameNeu;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Button ButtonJetztRegistrierenNeu;
        private System.Windows.Forms.TextBox TextboxEmailNeu;
        private System.Windows.Forms.TextBox TextboxPasswortWiederholenNeu;
        private System.Windows.Forms.Label LabelBenutzername;
        private System.Windows.Forms.Label LabelPasswortWiederholen;
        private System.Windows.Forms.TextBox TextboxBenutzernameNeu;
        private System.Windows.Forms.TextBox TextboxPasswortNeu;
        private System.Windows.Forms.Label LabelPasswortR;
        private System.Windows.Forms.Button ButtonFragezeichen;
        private System.Windows.Forms.CheckBox CheckboxAlsAdminHinzufügen;
    }
}