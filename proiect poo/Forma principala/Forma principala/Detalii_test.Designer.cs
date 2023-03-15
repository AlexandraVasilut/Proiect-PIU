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
            buton_pg_anterioara = new Button();
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
            // Detalii_test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.poza_pt_pg_cu_detalii_pt_test;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 853);
            Controls.Add(buton_pg_anterioara);
            DoubleBuffered = true;
            Name = "Detalii_test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalii_test";
            ResumeLayout(false);
        }

        #endregion

        private Button buton_pg_anterioara;
    }
}