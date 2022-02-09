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
    public partial class Form4 : Form
    {
        MyOlympiadContext db = new MyOlympiadContext();
        int Id;
        public Form4(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = db.PartyInfos.Where(w => w.Id == Id).First().FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.PartyInfos.Where(w => w.Id == Id).First().FullName = textBox1.Text;
            db.SaveChanges();
        }
    }
}
