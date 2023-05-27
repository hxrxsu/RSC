namespace RSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            this.Hide();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Hide();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            this.Hide();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            this.Hide();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 fr = new Form6();
            this.Hide();
            fr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 fr = new Form7();
            this.Hide();
            fr.ShowDialog();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лентина Варвара", "Автор");
        }
    }
}