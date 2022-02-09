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
    
    public partial class Form5 : Form
    {
        MyOlympiadContext db = new MyOlympiadContext();
        int Id;
        public Form5(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SportsSetingss.Where(o => o.Id == Id).First().CountSports = int.Parse(textBox1.Text);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = db.SportsSetingss.Where(o => o.Id == Id).First().CountSports.ToString() ;

        }
    }
}
