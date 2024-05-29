using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66840_Mehmet_Said_Unlu_T4
{
    internal class Product
    {

        public string productName;
        public string productBrand;
        public string price;

        private string id;
    
        public Product(string productName, string productBrand, string price)
        {
            this.productName = productName;
            this.productBrand = productBrand;
            this.price = price;
            this.id = GenerateId();
        }

        private string GenerateId()
        {
            Random rnd = new Random();


            string randomChars = new string(productName.Where(char.IsLetter).OrderBy(c => rnd.Next()).Take(2).ToArray());
            int randomNumber = rnd.Next(1000, 10000);
            return $"{randomChars.ToUpper()}-{randomNumber}";
        }

        public string GetId()
        {
            return id;
        }

        public Product(string data)
        {
            string[] splitedData = data.Split('$');
            productName = splitedData[0];
            productBrand = splitedData[1];
            price = splitedData[2];
        }
        public string GetData()
        {
            return $"{productName}${productBrand}${price}";
        }

    }
}
