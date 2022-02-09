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
    public partial class Form6 : Form
    {
        MyOlympiadContext db = new MyOlympiadContext();
        int Id;
        public Form6(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = db.SportViews.Where(o => o.Id == Id).First().SportName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SportViews.Where(o => o.Id == Id).First().SportName = textBox1.Text;
        }
    }
}
