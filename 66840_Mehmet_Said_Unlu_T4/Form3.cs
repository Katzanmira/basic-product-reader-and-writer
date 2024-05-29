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


namespace _66840_Mehmet_Said_Unlu_T4
{
    public partial class Form3 : Form
    {
        List<Product> Firms = new List<Product>();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;
            if (!string.IsNullOrEmpty(path))
            {
                
                
                    ReadDataAndCreateProduct(path);
                    AddProductsToListbox();
                
                
            }
        }

        private void AddProductsToListbox()
        {
            listBox1.Items.Clear();

            foreach (Product product in Firms)
            {
                string displayText = $"{product.productName}\t{product.productBrand}\t{product.price}";
                listBox1.Items.Add(displayText);
            }
        }

        private void ReadDataAndCreateProduct(string path)
        {
            Firms.Clear();

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Product p = new Product(line);
                    Firms.Add(p);
                }
            }
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
