namespace Forma_principala
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buton_pt_logare = new Button();
            buton_iesire = new Button();
            SuspendLayout();
            // 
            // buton_pt_logare
            // 
            buton_pt_logare.BackColor = SystemColors.GradientActiveCaption;
            buton_pt_logare.Font = new Font("Corbel", 18F, FontStyle.Italic, GraphicsUnit.Point);
            buton_pt_logare.ForeColor = SystemColors.ControlText;
            buton_pt_logare.Location = new Point(146, 70);
            buton_pt_logare.Name = "buton_pt_logare";
            buton_pt_logare.Size = new Size(499, 234);
            buton_pt_logare.TabIndex = 0;
            buton_pt_logare.Text = "LOGHEAZĂ-TE";
            buton_pt_logare.TextImageRelation = TextImageRelation.ImageAboveText;
            buton_pt_logare.UseVisualStyleBackColor = false;
            buton_pt_logare.Click += button1_Click;
            // 
            // buton_iesire
            // 
            buton_iesire.BackgroundImage = Properties.Resources.poza_pt_butonul_de_exit_pt_pg_principala;
            buton_iesire.Location = new Point(787, 700);
            buton_iesire.Name = "buton_iesire";
            buton_iesire.Size = new Size(128, 126);
            buton_iesire.TabIndex = 1;
            buton_iesire.UseVisualStyleBackColor = true;
            buton_iesire.Click += buton_iesire_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.poza_pt_pg_principala;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(982, 853);
            Controls.Add(buton_iesire);
            Controls.Add(buton_pt_logare);
            DoubleBuffered = true;
            Location = new Point(214, 432);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina_principala";
            ResumeLayout(false);
        }

        #endregion

        private Button buton_pt_logare;
        private Button buton_iesire;
    }
}