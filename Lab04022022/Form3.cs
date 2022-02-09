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
    public partial class Form3 : Form
    {
        MyOlympiadContext db = new MyOlympiadContext();
        int Id;
        public Form3(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Olympiads.Where(o => o.Id == Id).First().Year = int.Parse(textBox1.Text);
            db.Olympiads.Where(o => o.Id == Id).First().CityName = textBox2.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = db.Olympiads.Where(o => o.Id == Id).First().Year.ToString();
            textBox2.Text = db.Olympiads.Where(o => o.Id == Id).First().CityName;
        }
    }
}
