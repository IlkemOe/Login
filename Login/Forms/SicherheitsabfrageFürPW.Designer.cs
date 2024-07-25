namespace Login
{
    partial class SicherheitsabfrageFürPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SicherheitsabfrageFürPW));
            this.LabelSicherheitsfrageAuswählen = new System.Windows.Forms.Label();
            this.ComboboxSicherheitsfrageAuswählen = new System.Windows.Forms.ComboBox();
            this.SicherheitsfrageBeantworten = new System.Windows.Forms.Label();
            this.TextboxSIcherheitsfrageAntwort = new System.Windows.Forms.TextBox();
            this.LabelFragezeichen = new System.Windows.Forms.Label();
            this.ButtonZurückPWV = new System.Windows.Forms.Button();
            this.LabelErklärung = new System.Windows.Forms.Label();
            this.ButtonÜberprüfen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelSicherheitsfrageAuswählen
            // 
            this.LabelSicherheitsfrageAuswählen.AutoSize = true;
            this.LabelSicherheitsfrageAuswählen.Location = new System.Drawing.Point(176, 150);
            this.LabelSicherheitsfrageAuswählen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSicherheitsfrageAuswählen.Name = "LabelSicherheitsfrageAuswählen";
            this.LabelSicherheitsfrageAuswählen.Size = new System.Drawing.Size(146, 13);
            this.LabelSicherheitsfrageAuswählen.TabIndex = 0;
            this.LabelSicherheitsfrageAuswählen.Text = ">Sicherheitsfrage auswählen:";
            // 
            // ComboboxSicherheitsfrageAuswählen
            // 
            this.ComboboxSicherheitsfrageAuswählen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxSicherheitsfrageAuswählen.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxSicherheitsfrageAuswählen.FormattingEnabled = true;
            this.ComboboxSicherheitsfrageAuswählen.Items.AddRange(new object[] {
            "Wie hieß Ihr Lieblingslehrer?",
            "Wie heißt Ihr Lieblingsfilm?",
            "Was war Ihr erstes Auto?",
            "Wo sind Sie aufgewachsen?"});
            this.ComboboxSicherheitsfrageAuswählen.Location = new System.Drawing.Point(178, 141);
            this.ComboboxSicherheitsfrageAuswählen.Margin = new System.Windows.Forms.Padding(2);
            this.ComboboxSicherheitsfrageAuswählen.Name = "ComboboxSicherheitsfrageAuswählen";
            this.ComboboxSicherheitsfrageAuswählen.Size = new System.Drawing.Size(278, 30);
            this.ComboboxSicherheitsfrageAuswählen.TabIndex = 1;
            // 
            // SicherheitsfrageBeantworten
            // 
            this.SicherheitsfrageBeantworten.AutoSize = true;
            this.SicherheitsfrageBeantworten.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SicherheitsfrageBeantworten.Location = new System.Drawing.Point(175, 176);
            this.SicherheitsfrageBeantworten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SicherheitsfrageBeantworten.Name = "SicherheitsfrageBeantworten";
            this.SicherheitsfrageBeantworten.Size = new System.Drawing.Size(195, 17);
            this.SicherheitsfrageBeantworten.TabIndex = 2;
            this.SicherheitsfrageBeantworten.Text = "Sicherheitsfrage beantworten:";
            // 
            // TextboxSIcherheitsfrageAntwort
            // 
            this.TextboxSIcherheitsfrageAntwort.Font = new System.Drawing.Font("Roboto", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxSIcherheitsfrageAntwort.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TextboxSIcherheitsfrageAntwort.Location = new System.Drawing.Point(178, 195);
            this.TextboxSIcherheitsfrageAntwort.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxSIcherheitsfrageAntwort.Name = "TextboxSIcherheitsfrageAntwort";
            this.TextboxSIcherheitsfrageAntwort.Size = new System.Drawing.Size(278, 29);
            this.TextboxSIcherheitsfrageAntwort.TabIndex = 3;
            this.TextboxSIcherheitsfrageAntwort.MouseLeave += new System.EventHandler(this.Textbox_MouseLeave);
            this.TextboxSIcherheitsfrageAntwort.MouseHover += new System.EventHandler(this.Textbox_MouseHover);
            // 
            // LabelFragezeichen
            // 
            this.LabelFragezeichen.AutoSize = true;
            this.LabelFragezeichen.BackColor = System.Drawing.Color.GhostWhite;
            this.LabelFragezeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFragezeichen.ForeColor = System.Drawing.Color.Gray;
            this.LabelFragezeichen.Location = new System.Drawing.Point(472, 69);
            this.LabelFragezeichen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFragezeichen.Name = "LabelFragezeichen";
            this.LabelFragezeichen.Size = new System.Drawing.Size(23, 25);
            this.LabelFragezeichen.TabIndex = 4;
            this.LabelFragezeichen.Text = "?";
            this.LabelFragezeichen.MouseLeave += new System.EventHandler(this.LabelFragezeichen_MouseLeave);
            this.LabelFragezeichen.MouseHover += new System.EventHandler(this.LabelFragezeichen_MouseHover);
            // 
            // ButtonZurückPWV
            // 
            this.ButtonZurückPWV.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonZurückPWV.FlatAppearance.BorderSize = 0;
            this.ButtonZurückPWV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZurückPWV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZurückPWV.ForeColor = System.Drawing.Color.White;
            this.ButtonZurückPWV.Image = global::Login.Properties.Resources.circle_back;
            this.ButtonZurückPWV.Location = new System.Drawing.Point(64, 69);
            this.ButtonZurückPWV.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonZurückPWV.Name = "ButtonZurückPWV";
            this.ButtonZurückPWV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonZurückPWV.Size = new System.Drawing.Size(63, 38);
            this.ButtonZurückPWV.TabIndex = 5;
            this.ButtonZurückPWV.UseVisualStyleBackColor = false;
            this.ButtonZurückPWV.Click += new System.EventHandler(this.ButtonZurückPWV_Click);
            // 
            // LabelErklärung
            // 
            this.LabelErklärung.AutoSize = true;
            this.LabelErklärung.BackColor = System.Drawing.Color.Red;
            this.LabelErklärung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErklärung.ForeColor = System.Drawing.Color.White;
            this.LabelErklärung.Location = new System.Drawing.Point(175, 94);
            this.LabelErklärung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelErklärung.Name = "LabelErklärung";
            this.LabelErklärung.Size = new System.Drawing.Size(394, 34);
            this.LabelErklärung.TabIndex = 6;
            this.LabelErklärung.Text = "Geben Sie die Sicherheitsfrage ein die Sie beim Registrieren \r\nausgewählt haben u" +
    "m Ihr Passwort zu ändern";
            this.LabelErklärung.Visible = false;
            // 
            // ButtonÜberprüfen
            // 
            this.ButtonÜberprüfen.BackColor = System.Drawing.Color.Silver;
            this.ButtonÜberprüfen.FlatAppearance.BorderSize = 0;
            this.ButtonÜberprüfen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonÜberprüfen.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonÜberprüfen.ForeColor = System.Drawing.Color.White;
            this.ButtonÜberprüfen.Location = new System.Drawing.Point(273, 236);
            this.ButtonÜberprüfen.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonÜberprüfen.Name = "ButtonÜberprüfen";
            this.ButtonÜberprüfen.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonÜberprüfen.Size = new System.Drawing.Size(99, 25);
            this.ButtonÜberprüfen.TabIndex = 7;
            this.ButtonÜberprüfen.Text = "Überprüfen";
            this.ButtonÜberprüfen.UseVisualStyleBackColor = false;
            this.ButtonÜberprüfen.Click += new System.EventHandler(this.ButtonÜberprüfen_Click);
            // 
            // SicherheitsabfrageFürPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 327);
            this.Controls.Add(this.ButtonÜberprüfen);
            this.Controls.Add(this.LabelErklärung);
            this.Controls.Add(this.ButtonZurückPWV);
            this.Controls.Add(this.LabelFragezeichen);
            this.Controls.Add(this.TextboxSIcherheitsfrageAntwort);
            this.Controls.Add(this.SicherheitsfrageBeantworten);
            this.Controls.Add(this.ComboboxSicherheitsfrageAuswählen);
            this.Controls.Add(this.LabelSicherheitsfrageAuswählen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SicherheitsabfrageFürPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sicherheitsabfrage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SicherheitsabfrageFürPW_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSicherheitsfrageAuswählen;
        private System.Windows.Forms.ComboBox ComboboxSicherheitsfrageAuswählen;
        private System.Windows.Forms.Label SicherheitsfrageBeantworten;
        private System.Windows.Forms.TextBox TextboxSIcherheitsfrageAntwort;
        private System.Windows.Forms.Label LabelFragezeichen;
        private System.Windows.Forms.Button ButtonZurückPWV;
        private System.Windows.Forms.Label LabelErklärung;
        private System.Windows.Forms.Button ButtonÜberprüfen;
    }
}