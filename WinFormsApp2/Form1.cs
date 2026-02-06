namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sýnav1 = 0;
            int sýnav2 = 0;
            int sýnav3 = 0;
            
            sýnav1 = Convert.ToInt32(textBox1.Text);
            sýnav2 = Convert.ToInt32(textBox2.Text);
            sýnav3 = Convert.ToInt32(textBox3.Text);
            int ortalama = (sýnav1 + sýnav2 + sýnav3) / 3;
            MessageBox.Show(" ortalamanýz" + ortalama);
        }
    }
}
