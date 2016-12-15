using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void cboxotbüstürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxotbüstürü.SelectedItem.ToString() == "travego")
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 11) && (i != 5 || j < 2))
                        {

                            Button btn = new Button();
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Left = (btn.Width * j) ;
                            btn.Top = (btn.Height * i) ;

                            btn.Text = sayac.ToString();

                            btn.Click += Buttonclick;
                            btn.BackColor = Color.Blue;



                            panel1.Controls.Add(btn);


                            sayac++;
                        }
            
                    }
                }
            }
            
}
        private void Buttonclick(object sender, EventArgs e)
        {
            Button koltuk = sender as Button;
            labelkoltukno.Text = koltuk.Text.ToString();
            labelotobüstürü.Text = cboxotbüstürü.SelectedItem.ToString();

            if (labelotobüstürü.Text=="travego")
            {
                string yolcu = travegoyolcularisim[int.Parse(koltuk.Text) - 1];
            }

        }
        string[] travegoyolcularisim = new string[50];
        string[] travegoyolcularcinsiyet = new string[50];

        private void btnkydet_Click(object sender, EventArgs e)
        {
          

                travegoyolcularisim[int.Parse(labelkoltukno.Text) - 1] = textBox1.Text;
            if (labelotobüstürü.Text == "travego")
            {

                string cinsiyet;
                if (radioButton1.Checked)
                {
                    cinsiyet = "erkek";
                }
                else
                {
                    cinsiyet = " kadın";
                }
                travegoyolcularcinsiyet[int.Parse(labelkoltukno.Text) - 1] = cinsiyet;

            }
            textBox1.Text = "";
            labelkoltukno.Text = "";
            labelotobüstürü.Text = "";
        }
    }
    }

