namespace Forma_principala
{
    partial class Detalii_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalii_test));
            buton_pg_anterioara = new Button();
            lbl_det_test = new Label();
            SuspendLayout();
            // 
            // buton_pg_anterioara
            // 
            buton_pg_anterioara.BackgroundImage = Properties.Resources.poza_pt_butonul_care_te_duce_la_pg_anterioara1;
            buton_pg_anterioara.Location = new Point(839, 709);
            buton_pg_anterioara.Name = "buton_pg_anterioara";
            buton_pg_anterioara.Size = new Size(131, 132);
            buton_pg_anterioara.TabIndex = 0;
            buton_pg_anterioara.UseVisualStyleBackColor = true;
            buton_pg_anterioara.Click += buton_pg_anterioara_Click;
            // 
            // lbl_det_test
            // 
            lbl_det_test.AutoSize = true;
            lbl_det_test.BackColor = SystemColors.WindowFrame;
            lbl_det_test.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_det_test.ForeColor = SystemColors.Control;
            lbl_det_test.Location = new Point(81, 111);
            lbl_det_test.Name = "lbl_det_test";
            lbl_det_test.Size = new Size(502, 690);
            lbl_det_test.TabIndex = 3;
            lbl_det_test.Text = resources.GetString("lbl_det_test.Text");
            lbl_det_test.TextAlign = ContentAlignment.TopCenter;
            lbl_det_test.Click += label1_Click;
            // 
            // Detalii_test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.poza_pt_pg_cu_detalii_pt_test;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 853);
            Controls.Add(lbl_det_test);
            Controls.Add(buton_pg_anterioara);
            DoubleBuffered = true;
            Name = "Detalii_test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalii_test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buton_pg_anterioara;
        private Label lbl_det_test;
    }
}