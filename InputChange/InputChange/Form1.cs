using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt1 = textBox1.Text;

            if (string.IsNullOrWhiteSpace(txt1))
            {

                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Add("Değer :" + txt1);
            }

        }

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        public void SaveSettings()
        {

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter saver = new System.IO.StreamWriter(save.FileName);

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    saver.WriteLine((string)listBox1.Items[i]);
                }

                saver.Close();
            }

            save.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedItems.Count != 0 && comboBox1.Text == "Metin Sil")
            {
                while (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }

            if (comboBox1.Text == "İlk Karşılaşılan Metnin Yerini Bul")
            {
                if (listBox1.Items.Count > 0)
                {
                    ListBox list = listBox1;
                    textBox2.Text = list.Items[0].ToString();
                }
                else
                {
                    MessageBox.Show("Değer Bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }

            if (comboBox1.Text == "Son Karşılaşılan Metnin Yerini Bul")
            {
                
                if (listBox1.Items.Count > 0)
                {
                    ListBox list = listBox1;
                    textBox2.Text = list.Items[list.Items.Count - 1].ToString();
                }
                else
                {
                    MessageBox.Show("Değer Bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

            if (listBox1.SelectedItems.Count != 0 && comboBox1.Text == "Değer Değiştir")
            {
                ListBox list = listBox1;
                int chooser = listBox1.SelectedIndex;
                string txt = textBox1.Text;

                list.Items.RemoveAt(chooser);
                list.Items.Insert(chooser,  "Değer :" + txt.ToString());


            }


            if (listBox1.SelectedItems.Count != 0 && comboBox1.Text == "BÜYÜK HARFE DÖNÜŞTÜR")
            {
                ListBox list = listBox1;
                int chooser = listBox1.SelectedIndex;
                string txt = listBox1.SelectedItem.ToString();

                list.Items.RemoveAt(chooser);
                list.Items.Insert(chooser, "" + txt.ToString().ToUpper());
            }


            if (listBox1.SelectedItems.Count != 0 && comboBox1.Text == "küçük harfe dönüştür")
            {
                ListBox list = listBox1;
                int chooser = listBox1.SelectedIndex;
                string txt = listBox1.SelectedItem.ToString();

                list.Items.RemoveAt(chooser);
                list.Items.Insert(chooser, "" + txt.ToString().ToLower());
            }


            






        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                SaveSettings();
                MessageBox.Show("Başarıyla Kayıt Edildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kaydedilicek Bir Şey Yok!.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string toFind = textBox3.Text;

            if (textBox3.Text == "") listBox2.Items.Clear();
            else
            {
                foreach (string s in listBox1.Items)
                {
                    if (s.Contains(toFind)) listBox2.Items.Add(s);
                }
            }
        }
    }






























}
































