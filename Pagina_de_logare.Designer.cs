namespace Forma_principala
{
    partial class Pagina_de_logare
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
            buton_pg_anterioara = new Button();
            eticheta_pt_nume = new Label();
            eticheta_pt_prenume = new Label();
            eticheta_initiala_tata = new Label();
            eticheta_clasa = new Label();
            cadru_didactic = new Label();
            buton_desc_detalii = new Button();
            btn_logare_desc_pg_nou = new Button();
            txt_Nume = new TextBox();
            txt_Prenume = new TextBox();
            txt_Initiala_tata = new TextBox();
            comboBox_nume_prof = new ComboBox();
            comboBox_clasa = new ComboBox();
            SuspendLayout();
            // 
            // buton_pg_anterioara
            // 
            buton_pg_anterioara.BackgroundImage = Properties.Resources.poza_pt_butonul_care_te_duce_la_pg_anterioara;
            buton_pg_anterioara.Location = new Point(12, 708);
            buton_pg_anterioara.Name = "buton_pg_anterioara";
            buton_pg_anterioara.Size = new Size(131, 133);
            buton_pg_anterioara.TabIndex = 0;
            buton_pg_anterioara.UseVisualStyleBackColor = true;
            buton_pg_anterioara.Click += buton_pg_anterioara_Click;
            // 
            // eticheta_pt_nume
            // 
            eticheta_pt_nume.AllowDrop = true;
            eticheta_pt_nume.AutoEllipsis = true;
            eticheta_pt_nume.BackColor = SystemColors.ButtonFace;
            eticheta_pt_nume.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            eticheta_pt_nume.Location = new Point(201, 83);
            eticheta_pt_nume.Margin = new Padding(0);
            eticheta_pt_nume.Name = "eticheta_pt_nume";
            eticheta_pt_nume.Size = new Size(122, 46);
            eticheta_pt_nume.TabIndex = 1;
            eticheta_pt_nume.Text = "Nume:";
            eticheta_pt_nume.Visible = false;
            // 
            // eticheta_pt_prenume
            // 
            eticheta_pt_prenume.AutoSize = true;
            eticheta_pt_prenume.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            eticheta_pt_prenume.Location = new Point(157, 174);
            eticheta_pt_prenume.Name = "eticheta_pt_prenume";
            eticheta_pt_prenume.Size = new Size(166, 46);
            eticheta_pt_prenume.TabIndex = 2;
            eticheta_pt_prenume.Text = "Prenume:";
            // 
            // eticheta_initiala_tata
            // 
            eticheta_initiala_tata.AutoSize = true;
            eticheta_initiala_tata.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            eticheta_initiala_tata.Location = new Point(80, 256);
            eticheta_initiala_tata.Name = "eticheta_initiala_tata";
            eticheta_initiala_tata.Size = new Size(243, 46);
            eticheta_initiala_tata.TabIndex = 3;
            eticheta_initiala_tata.Text = "Inițiala tatălui:";
            // 
            // eticheta_clasa
            // 
            eticheta_clasa.AutoSize = true;
            eticheta_clasa.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            eticheta_clasa.Location = new Point(214, 432);
            eticheta_clasa.Name = "eticheta_clasa";
            eticheta_clasa.Size = new Size(109, 46);
            eticheta_clasa.TabIndex = 4;
            eticheta_clasa.Text = "Clasa:";
            // 
            // cadru_didactic
            // 
            cadru_didactic.AutoSize = true;
            cadru_didactic.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            cadru_didactic.Location = new Point(65, 342);
            cadru_didactic.Name = "cadru_didactic";
            cadru_didactic.Size = new Size(258, 46);
            cadru_didactic.TabIndex = 6;
            cadru_didactic.Text = "Cadrul didactic:";
            // 
            // buton_desc_detalii
            // 
            buton_desc_detalii.BackColor = Color.CornflowerBlue;
            buton_desc_detalii.CausesValidation = false;
            buton_desc_detalii.Cursor = Cursors.Help;
            buton_desc_detalii.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buton_desc_detalii.Location = new Point(839, 708);
            buton_desc_detalii.Name = "buton_desc_detalii";
            buton_desc_detalii.Size = new Size(131, 133);
            buton_desc_detalii.TabIndex = 7;
            buton_desc_detalii.Text = "Despre test";
            buton_desc_detalii.UseVisualStyleBackColor = false;
            buton_desc_detalii.Click += buton_desc_detalii_Click;
            // 
            // btn_logare_desc_pg_nou
            // 
            btn_logare_desc_pg_nou.BackColor = Color.CornflowerBlue;
            btn_logare_desc_pg_nou.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logare_desc_pg_nou.Location = new Point(370, 657);
            btn_logare_desc_pg_nou.Name = "btn_logare_desc_pg_nou";
            btn_logare_desc_pg_nou.Size = new Size(254, 94);
            btn_logare_desc_pg_nou.TabIndex = 8;
            btn_logare_desc_pg_nou.Text = "Loghează-te";
            btn_logare_desc_pg_nou.UseVisualStyleBackColor = false;
            btn_logare_desc_pg_nou.Click += button1_Click;
            // 
            // txt_Nume
            // 
            txt_Nume.Location = new Point(379, 83);
            txt_Nume.Name = "txt_Nume";
            txt_Nume.Size = new Size(272, 27);
            txt_Nume.TabIndex = 9;
            // 
            // txt_Prenume
            // 
            txt_Prenume.Location = new Point(379, 193);
            txt_Prenume.Name = "txt_Prenume";
            txt_Prenume.Size = new Size(272, 27);
            txt_Prenume.TabIndex = 10;
            // 
            // txt_Initiala_tata
            // 
            txt_Initiala_tata.Location = new Point(379, 273);
            txt_Initiala_tata.Name = "txt_Initiala_tata";
            txt_Initiala_tata.Size = new Size(272, 27);
            txt_Initiala_tata.TabIndex = 11;
            // 
            // comboBox_nume_prof
            // 
            comboBox_nume_prof.AutoCompleteCustomSource.AddRange(new string[] { "Floricica Ioana", "Vasilut Lăcrămioara", "Paicu Anastasia", "Prodan Cristian", "Andronic Vasilică", "Popescu Maria-Ioana", "Carare Maricica-Valeria", "Uilăcan Darius", "Cristescu Daniela", "Mucenicu Crina Mariana " });
            comboBox_nume_prof.FormattingEnabled = true;
            comboBox_nume_prof.Location = new Point(382, 364);
            comboBox_nume_prof.Name = "comboBox_nume_prof";
            comboBox_nume_prof.Size = new Size(269, 28);
            comboBox_nume_prof.TabIndex = 12;
            // 
            // comboBox_clasa
            // 
            comboBox_clasa.AutoCompleteCustomSource.AddRange(new string[] { "5", "6", "7", "8" });
            comboBox_clasa.FormattingEnabled = true;
            comboBox_clasa.Location = new Point(382, 450);
            comboBox_clasa.Name = "comboBox_clasa";
            comboBox_clasa.Size = new Size(184, 28);
            comboBox_clasa.TabIndex = 13;
            // 
            // Pagina_de_logare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.poza_pt_pg_de_logare;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 853);
            Controls.Add(comboBox_clasa);
            Controls.Add(comboBox_nume_prof);
            Controls.Add(txt_Initiala_tata);
            Controls.Add(txt_Prenume);
            Controls.Add(txt_Nume);
            Controls.Add(btn_logare_desc_pg_nou);
            Controls.Add(buton_desc_detalii);
            Controls.Add(cadru_didactic);
            Controls.Add(eticheta_clasa);
            Controls.Add(eticheta_initiala_tata);
            Controls.Add(eticheta_pt_prenume);
            Controls.Add(eticheta_pt_nume);
            Controls.Add(buton_pg_anterioara);
            DoubleBuffered = true;
            Name = "Pagina_de_logare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina_de_logare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buton_pg_anterioara;
        private Label eticheta_pt_nume;
        private Label eticheta_pt_prenume;
        private Label eticheta_initiala_tata;
        private Label eticheta_clasa;
        private Label cadru_didactic;
        private Button buton_desc_detalii;
        private Button btn_logare_desc_pg_nou;
        private TextBox txt_Nume;
        private TextBox txt_Prenume;
        private TextBox txt_Initiala_tata;
        private ComboBox comboBox_nume_prof;
        private ComboBox comboBox_clasa;
    }
}