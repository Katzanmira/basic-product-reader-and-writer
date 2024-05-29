using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace _66840_Mehmet_Said_Unlu_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Product p = CreateProduct();

            WriteProductOnFile(p);


        }

        private Product CreateProduct()
        {
            return new Product(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void WriteProductOnFile(Product p)
        {
             FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(p.GetData());

            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }


    }
}
