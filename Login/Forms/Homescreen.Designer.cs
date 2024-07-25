namespace Login
{
    partial class Homescreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homescreen));
            this.LabelBenutzername = new System.Windows.Forms.Label();
            this.LabelAnmeldeNachricht = new System.Windows.Forms.Label();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.LabelDatum = new System.Windows.Forms.Label();
            this.LabelUhrzeit = new System.Windows.Forms.Label();
            this.TimerUhrzeit = new System.Windows.Forms.Timer(this.components);
            this.ButtonBenutzerliste = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.ButtonSpeichern = new System.Windows.Forms.Button();
            this.ButtonNeu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelBenutzername
            // 
            this.LabelBenutzername.AutoSize = true;
            this.LabelBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.LabelBenutzername.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBenutzername.Location = new System.Drawing.Point(388, 214);
            this.LabelBenutzername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBenutzername.Name = "LabelBenutzername";
            this.LabelBenutzername.Size = new System.Drawing.Size(264, 30);
            this.LabelBenutzername.TabIndex = 1;
            this.LabelBenutzername.Text = "Herzlich Willkommen, !";
            // 
            // LabelAnmeldeNachricht
            // 
            this.LabelAnmeldeNachricht.AutoSize = true;
            this.LabelAnmeldeNachricht.BackColor = System.Drawing.Color.Transparent;
            this.LabelAnmeldeNachricht.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAnmeldeNachricht.Location = new System.Drawing.Point(444, 267);
            this.LabelAnmeldeNachricht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAnmeldeNachricht.Name = "LabelAnmeldeNachricht";
            this.LabelAnmeldeNachricht.Size = new System.Drawing.Size(197, 24);
            this.LabelAnmeldeNachricht.TabIndex = 2;
            this.LabelAnmeldeNachricht.Text = "Sie sind angemeldet!";
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonLogout.FlatAppearance.BorderSize = 0;
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogout.ForeColor = System.Drawing.Color.White;
            this.ButtonLogout.Location = new System.Drawing.Point(841, 25);
            this.ButtonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(100, 39);
            this.ButtonLogout.TabIndex = 3;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseVisualStyleBackColor = false;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // LabelDatum
            // 
            this.LabelDatum.AutoSize = true;
            this.LabelDatum.BackColor = System.Drawing.Color.Transparent;
            this.LabelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDatum.ForeColor = System.Drawing.Color.Black;
            this.LabelDatum.Location = new System.Drawing.Point(28, 523);
            this.LabelDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDatum.Name = "LabelDatum";
            this.LabelDatum.Size = new System.Drawing.Size(59, 20);
            this.LabelDatum.TabIndex = 4;
            this.LabelDatum.Text = "Datum";
            // 
            // LabelUhrzeit
            // 
            this.LabelUhrzeit.AutoSize = true;
            this.LabelUhrzeit.BackColor = System.Drawing.Color.Transparent;
            this.LabelUhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUhrzeit.Location = new System.Drawing.Point(871, 523);
            this.LabelUhrzeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUhrzeit.Name = "LabelUhrzeit";
            this.LabelUhrzeit.Size = new System.Drawing.Size(63, 20);
            this.LabelUhrzeit.TabIndex = 5;
            this.LabelUhrzeit.Text = "Uhrzeit";
            // 
            // TimerUhrzeit
            // 
            this.TimerUhrzeit.Enabled = true;
            this.TimerUhrzeit.Tick += new System.EventHandler(this.TimerUhrzeit_Tick);
            // 
            // ButtonBenutzerliste
            // 
            this.ButtonBenutzerliste.AutoSize = true;
            this.ButtonBenutzerliste.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonBenutzerliste.FlatAppearance.BorderSize = 0;
            this.ButtonBenutzerliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBenutzerliste.Font = new System.Drawing.Font("Roboto", 13F);
            this.ButtonBenutzerliste.ForeColor = System.Drawing.Color.White;
            this.ButtonBenutzerliste.Location = new System.Drawing.Point(684, 386);
            this.ButtonBenutzerliste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBenutzerliste.Name = "ButtonBenutzerliste";
            this.ButtonBenutzerliste.Size = new System.Drawing.Size(171, 39);
            this.ButtonBenutzerliste.TabIndex = 6;
            this.ButtonBenutzerliste.Text = "Benutzerliste";
            this.ButtonBenutzerliste.UseVisualStyleBackColor = false;
            this.ButtonBenutzerliste.Visible = false;
            this.ButtonBenutzerliste.Click += new System.EventHandler(this.ButtonBenutzerliste_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(28, 25);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(67, 20);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "Status: ";
            // 
            // dg
            // 
            this.dg.AllowDrop = true;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(85, 127);
            this.dg.Margin = new System.Windows.Forms.Padding(4);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.Size = new System.Drawing.Size(856, 230);
            this.dg.TabIndex = 8;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // ButtonSpeichern
            // 
            this.ButtonSpeichern.AutoSize = true;
            this.ButtonSpeichern.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonSpeichern.FlatAppearance.BorderSize = 0;
            this.ButtonSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSpeichern.Font = new System.Drawing.Font("Roboto", 13F);
            this.ButtonSpeichern.ForeColor = System.Drawing.Color.White;
            this.ButtonSpeichern.Location = new System.Drawing.Point(171, 386);
            this.ButtonSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSpeichern.Name = "ButtonSpeichern";
            this.ButtonSpeichern.Size = new System.Drawing.Size(184, 49);
            this.ButtonSpeichern.TabIndex = 9;
            this.ButtonSpeichern.Text = "Aktualisieren";
            this.ButtonSpeichern.UseVisualStyleBackColor = false;
            this.ButtonSpeichern.Visible = false;
            this.ButtonSpeichern.Click += new System.EventHandler(this.ButtonSpeichern_Click);
            // 
            // ButtonNeu
            // 
            this.ButtonNeu.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNeu.FlatAppearance.BorderSize = 0;
            this.ButtonNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNeu.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNeu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ButtonNeu.Location = new System.Drawing.Point(85, 86);
            this.ButtonNeu.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNeu.Name = "ButtonNeu";
            this.ButtonNeu.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonNeu.Size = new System.Drawing.Size(84, 33);
            this.ButtonNeu.TabIndex = 10;
            this.ButtonNeu.Text = "Neu";
            this.ButtonNeu.UseVisualStyleBackColor = false;
            this.ButtonNeu.Visible = false;
            this.ButtonNeu.Click += new System.EventHandler(this.ButtonNeu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(171, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Neu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // Homescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonNeu);
            this.Controls.Add(this.ButtonSpeichern);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.ButtonBenutzerliste);
            this.Controls.Add(this.LabelUhrzeit);
            this.Controls.Add(this.LabelDatum);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.LabelAnmeldeNachricht);
            this.Controls.Add(this.LabelBenutzername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Homescreen";
            this.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homescreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homescreen_FormClosing);
            this.Load += new System.EventHandler(this.Homescreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelBenutzername;
        private System.Windows.Forms.Label LabelAnmeldeNachricht;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Label LabelDatum;
        private System.Windows.Forms.Label LabelUhrzeit;
        private System.Windows.Forms.Timer TimerUhrzeit;
        private System.Windows.Forms.Button ButtonBenutzerliste;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.DataGridView dg;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Button ButtonSpeichern;
        private System.Windows.Forms.Button ButtonNeu;
        private System.Windows.Forms.Button button1;
    }
}