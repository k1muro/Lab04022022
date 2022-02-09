using Lab04022022.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04022022
{
    public partial class Form1 : Form
    {
        string Picture;
        SqlConnection conn = null;
        string fileName = "";
        string conn_string = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        MyOlympiadContext db = new MyOlympiadContext();
        SqlCommand comm = new SqlCommand();
     

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            HideAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        /* private void LoadPicture()
         {
             try
             {
                 byte[] bytes;
                 bytes = CreateCopy();
                 conn.Open();
                 SqlCommand comm = new SqlCommand("insert into Pictures(bookid, name, picture) values (@bookid, @name, @picture); ", conn);
                 if (tbIndex.Text == null || tbIndex.Text.Length == 0) return;
                 int index = -1;
                 int.TryParse(tbIndex.Text, out index);
                 if (index == -1) return;
                 comm.Parameters.Add("@bookid", SqlDbType.Int).Value = index;
                 comm.Parameters.Add("@name", SqlDbType.NVarChar, 255).
                 Value = fileName;
                 comm.Parameters.Add("@picture", SqlDbType.Image, bytes.Length).
                 Value = bytes;
                 comm.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 if (conn != null) conn.Close();
             }
         }*/
 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                HideAll();
                label2.Visible = true;
                textBox1.Visible = true;
                button3.Visible = true;
                conn = new SqlConnection();
                conn.ConnectionString = conn_string;
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from Countries;";
                DataTable table = new DataTable();
                using (DbDataReader reader = comm.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (reader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i <
                               reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.
                               GetFieldValue<Object>(i);

                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                HideAll();
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button4.Visible = true;
                conn = new SqlConnection();
                conn.ConnectionString = conn_string;
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from Olympiads;";
                DataTable table = new DataTable();
                using (DbDataReader reader = comm.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (reader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i <
                               reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.
                               GetFieldValue<Object>(i);

                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                HideAll();
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                button5.Visible = true;
                conn = new SqlConnection();
                conn.ConnectionString = conn_string;
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from PartyInfoes;";
                DataTable table = new DataTable();
                using (DbDataReader reader = comm.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (reader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i <
                               reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.
                               GetFieldValue<Object>(i);

                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                HideAll();
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                button6.Visible = true;
                conn = new SqlConnection();
                conn.ConnectionString = conn_string;
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from Results;";
                DataTable table = new DataTable();
                using (DbDataReader reader = comm.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (reader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i <
                               reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.
                               GetFieldValue<Object>(i);

                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                HideAll();
                label14.Visible = true;
                textBox12.Visible = true;
                button7.Visible = true;
                conn = new SqlConnection();
                conn.ConnectionString = conn_string;
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from Seasons;";
                DataTable table = new DataTable();
                using (DbDataReader reader = comm.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (reader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i <
                               reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.
                               GetFieldValue<Object>(i);

                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                HideAll();
                label15.Visible = true;
                label16.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                button8.Visible = true;
                conn = new SqlConnection();
                conn.ConnectionString = conn_string;
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from SportsSetings;";
                DataTable table = new DataTable();
                using (DbDataReader reader = comm.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (reader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i <
                               reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.
                               GetFieldValue<Object>(i);

                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                HideAll();
                label17.Visible = true;
                label18.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                button9.Visible = true;
                conn = new SqlConnection();
                conn.ConnectionString = conn_string;
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from SportViews;";
                DataTable table = new DataTable();
                using (DbDataReader reader = comm.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (reader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i <
                               reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.
                               GetFieldValue<Object>(i);

                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }

        }
        public void HideAll()
        {
            label2.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button4.Visible = false;

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button5.Visible = false;

            //9-13
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            button6.Visible = false;


            label14.Visible = false;
            textBox12.Visible = false;
            button7.Visible = false;


            label15.Visible = false;
            label16.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button8.Visible = false;


            label17.Visible = false;
            label18.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            button9.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graphics File|*.bmp; *.gif; *.jpg; *.png";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Picture = ofd.FileName;
                db.PartyInfos.Add(new PartyInfo { FullName = textBox5.Text, DateBirth=DateTime.Now, Photo = CreateCopy() });
                db.SaveChanges();
                
            }
        }
        private byte[] CreateCopy()
        {
            Image img = Image.FromFile(Picture);
            int maxWidth = 300, maxHeight = 300;
            //we pick the width
            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);
            Image mi = new Bitmap(newWidth, newHeight);
            //the Picture is in the memory
            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();
            //поток для ввода|вывода байт из памяти
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();//выносим в поток все данные
                       //из буфера
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            comm = conn.CreateCommand();
            comm.CommandText = "insert into Countries (CountryName) values (@cn)";
            comm.Parameters.AddWithValue("@cn", textBox1.Text);
            comm.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "insert into Olympiads(Year,CityName,CountryId) values(@y,@c,@ci)";
            comm.Parameters.AddWithValue("@y", textBox2.Text);
            comm.Parameters.AddWithValue("@c", textBox3.Text);
            comm.Parameters.AddWithValue("@ci", textBox4.Text);
            comm.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "insert into Results(OlympiadId,PartyinfoId,SportViewId,ResultName,Position) values(@oi,@pi,@si,@rn,@p)";
            comm.Parameters.AddWithValue("@oi", int.Parse(textBox7.Text));
            comm.Parameters.AddWithValue("@pi", int.Parse(textBox8.Text));
            comm.Parameters.AddWithValue("@si", int.Parse(textBox9.Text));
            comm.Parameters.AddWithValue("@rn", textBox10.Text);
            comm.Parameters.AddWithValue("@p", int.Parse(textBox11.Text));
            comm.ExecuteNonQuery();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "insert into Seasons(SeasonName) values(@s)";
            comm.Parameters.AddWithValue("@oi", int.Parse(textBox7.Text));
            comm.Parameters.AddWithValue("@pi", int.Parse(textBox8.Text));
            comm.Parameters.AddWithValue("@si", int.Parse(textBox9.Text));
            comm.Parameters.AddWithValue("@rn", textBox10.Text);
            comm.Parameters.AddWithValue("@p", int.Parse(textBox11.Text));
            comm.ExecuteNonQuery();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "insert into SportsSetings(CountSports,ResultId) values(@cs,@ri)";
            comm.Parameters.AddWithValue("@cs", textBox13.Text);
            comm.Parameters.AddWithValue("@ri", int.Parse(textBox14.Text));
            comm.ExecuteNonQuery();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "insert into SportViews(SportName,PartyInfo_Id) values(@s,@pi)";
            comm.Parameters.AddWithValue("@s", textBox15.Text);
            comm.Parameters.AddWithValue("@pi", int.Parse(textBox16.Text));
            comm.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (MyOlympiadContext db = new MyOlympiadContext())
            {
                Country c = db.Countrys.Where( o=>o.Id == 5).First();
                db.Countrys.Remove(c);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(int.Parse(textBox17.Text));
            form2.ShowDialog();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(int.Parse(textBox18.Text));
            form3.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(int.Parse(textBox19.Text));
            form4.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(int.Parse(textBox20.Text));
            form5.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(int.Parse(textBox21.Text));
            form6.ShowDialog();
        }
    }
}
