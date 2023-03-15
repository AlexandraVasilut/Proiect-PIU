namespace Forma_principala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagina_de_logare pg_log = new Pagina_de_logare();
            pg_log.Show(); 
        }

        private void buton_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}