using System;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meyveler = { "Kiraz", "Uzum", "Falan" };
            comboBox1.Items.AddRange(meyveler);
            //comboBox1.Items.Add("Kiraz");
            //comboBox1.Items.Add("Üzüm");
            //comboBox1.Items.Add("Falan");
            listBox1.Items.AddRange(meyveler);
            listBox1.SelectionMode = SelectionMode.One;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            MessageBox.Show($"{dateTimePicker1.Value:dd-MM-yy HH.mm}");
            MessageBox.Show($"Urunun fiyati: {numericUpDown1.Value:c2}");
        }

        private int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (sayac++).ToString();
        }
    }
}
