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
            eticheta_materie = new Label();
            cadru_didactic = new Label();
            buton_desc_detalii = new Button();
            button1 = new Button();
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
            eticheta_clasa.Location = new Point(214, 525);
            eticheta_clasa.Name = "eticheta_clasa";
            eticheta_clasa.Size = new Size(109, 46);
            eticheta_clasa.TabIndex = 4;
            eticheta_clasa.Text = "Clasa:";
            // 
            // eticheta_materie
            // 
            eticheta_materie.AutoSize = true;
            eticheta_materie.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            eticheta_materie.Location = new Point(176, 434);
            eticheta_materie.Name = "eticheta_materie";
            eticheta_materie.Size = new Size(147, 46);
            eticheta_materie.TabIndex = 5;
            eticheta_materie.Text = "Materia:";
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
            buton_desc_detalii.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buton_desc_detalii.Location = new Point(839, 708);
            buton_desc_detalii.Name = "buton_desc_detalii";
            buton_desc_detalii.Size = new Size(131, 133);
            buton_desc_detalii.TabIndex = 7;
            buton_desc_detalii.Text = "Despre test";
            buton_desc_detalii.UseVisualStyleBackColor = false;
            buton_desc_detalii.Click += buton_desc_detalii_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(370, 657);
            button1.Name = "button1";
            button1.Size = new Size(254, 94);
            button1.TabIndex = 8;
            button1.Text = "Loghează-te";
            button1.UseVisualStyleBackColor = false;
            // 
            // Pagina_de_logare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.poza_pt_pg_de_logare;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 853);
            Controls.Add(button1);
            Controls.Add(buton_desc_detalii);
            Controls.Add(cadru_didactic);
            Controls.Add(eticheta_materie);
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
        private Label eticheta_materie;
        private Label cadru_didactic;
        private Button buton_desc_detalii;
        private Button button1;
    }
}