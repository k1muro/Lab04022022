using Lab04022022.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04022022
{
    public partial class Form2 : Form
    {
        MyOlympiadContext db = new MyOlympiadContext();
        int Id;

        public Form2(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = db.Countrys.Where(o => o.Id == Id).First().CountryName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Countrys.Where(o => o.Id == Id).First().CountryName = textBox1.Text;
            db.SaveChanges();
            this.Close();
        }
    }
}
