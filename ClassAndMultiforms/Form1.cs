using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndMultiforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            Pet myDog = new Pet();
            myDog.Name = "Scrapy";
            myDog.Age = 2;
            MessageBox.Show("Your dog's name is " + myDog.Name + "\n" +
                "Your Dog's age is " + myDog.Age + " year(s)", "Pet Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            Pet myCat = new Pet();
            myCat.Name = "Fluffy";
            myCat.Age = 1;
            MessageBox.Show("Your cat's name is " + myCat.Name + "\n" + 
                "Your Cat's age is " + myCat.Age + " year(s)", "Pet Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
