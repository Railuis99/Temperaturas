using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula10
{
    public partial class Form1 : Form
    {
        string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

        int[] tempMin = {5, 3, 10, 15, 15, 20, 23, 25, 20, 23, 15, 12};

        int[] tempMax = {17, 15, 19, 25, 27, 30, 40, 48, 37, 30, 25, 19};

        int[] temp = new int[12];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random tempe = new Random();

            //listaMes.Items.AddRange(meses);

            for(int x = 0; x < meses.Length; x++)
            {
                listaMes.Items.Add(meses[x]);

                temp[x] = tempe.Next(tempMin[x], tempMax[x] + 1);
                listaTemp.Items.Add(temp[x]);
            }

            /*
              for(int x = 0; x < temp.Length; x++)
              {
                temp[x] = tempe.Next(tempMin[x], tempMax[x] + 1);
                listaTemp.Items.Add(temp[x]);
              }
             */

            txtTempReg.Text = temp.Length.ToString();
            //listaTemp.Items.Count();

            listaMes.SelectedIndex = 0;
            listaTemp.SelectedIndex = 0;

            //listaMes.SetSelected(0, true);
            //listaTemp.SetSelected(0, true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numMes = Convert.ToInt32(selMes.Value) - 1;

            temp[numMes] = Convert.ToInt16(txtNTemp.Text);

            listaTemp.Items.Clear();

            for(int x = 0; x < meses.Length; x++)
                listaTemp.Items.Add(temp[x]);

            //listaTemp.Items[numMes -1] = Convert.ToInt16(txtNTemp.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numMes = Convert.ToInt32(selMes.Value) - 1;

            temp[numMes] = -100;

            listaTemp.Items.Clear();

            for (int x = 0; x < meses.Length; x++)
            {
                if (temp[x] == -100)
                    listaTemp.Items.Add("--");
                else
                    listaTemp.Items.Add(temp[x]);
            }

            //listaTemp.Items[pos -1] = temp[nMes];
        }

        private void selMes_ValueChanged(object sender, EventArgs e)
        {
            int numMes = (int)selMes.Value;

            txtMesTxt.Text = meses[numMes - 1];

            listaMes.SelectedIndex = numMes - 1;
        }

        private void listaMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaTemp.SelectedIndex = listaMes.SelectedIndex;
            selMes.Value = listaMes.SelectedIndex + 1;

            /*
            if(listaMes.SelectedIndex != -1)
                selMes.Value = listaMes.SelectedIndex + 1;
            */
        }

        private void listaTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaMes.SelectedIndex = listaTemp.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cont = 0;

            for (int x = 0; x < temp.Length; x++)
            {
                if (temp[x] != -100)
                    cont++;   
            }

            txtTempReg.Text = cont.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float tempMed = 0;
            int tempMax = 0, tempMin = 100;

            for(int x = 0;x < temp.Length; x++)
            {
                if (temp[x] != -100)
                    tempMed = tempMed + temp[x];

                if (temp[x] > tempMax)
                    tempMax = temp[x];
                
                if ((temp[x] < tempMin) && (temp[x] != -100))
                    tempMin = temp[x];
            }
            //MessageBox.Show(tempMed.ToString());

            tempMed = tempMed / Convert.ToInt16(txtTempReg.Text);

            txtTempMedia.Text = Math.Round(tempMed, 2).ToString();
            txtTempMax.Text = tempMax.ToString();
            txtTempMin.Text = tempMin.ToString();

            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tempMax = Convert.ToInt16(txtTempMax.Text);

            for(int x = 0; x < temp.Length; x++)
            {
                if (tempMax == temp[x])
                    listaTemp.SelectedIndex = x;
            }
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tempMin = Convert.ToInt16(txtTempMin.Text);
            int cont = 100;

            for(int x = 0; x < temp.Length; x++)
            {
                if(tempMin == temp[x])
                    listaTemp.SelectedIndex = x;

                if ((temp[x] < cont) && (temp[x] != tempMin))
                    cont = temp[x];
                
                if(cont == temp[x])
                    listaTemp.SelectedIndex = x;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int tempMin = Convert.ToInt16(txtTempMin.Text);
            int cont = 100;

            for (int x = 0; x < temp.Length; x++)
            {
                if ((temp[x] < cont && temp[x] != -100) && (temp[x] != tempMin))
                    cont = temp[x];

                if (cont == temp[x])
                    listaTemp.SelectedIndex = x;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int tri1 = temp.Length / 4;
            float tempMed = 0;
            int tempMax = 0, tempMin = 100, tempReg = 0;

            for (int x = 0; x < tri1; x++)
            {
                if (temp[x] != -100)
                {
                    tempMed = tempMed + temp[x];
                    tempReg++;
                }
                    

                if (temp[x] > tempMax)
                    tempMax = temp[x];

                if ((temp[x] < tempMin) && (temp[x] != -100))
                    tempMin = temp[x];
            }
            //MessageBox.Show(tempMed.ToString());

            txtTempReg.Text = tempReg.ToString();

            tempMed = tempMed / tempReg;
            
            txtTempMedia.Text = Math.Round(tempMed, 2).ToString();
            txtTempMax.Text = tempMax.ToString();
            txtTempMin.Text = tempMin.ToString();

            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int tri1 = temp.Length / 4;
            int tri2 = tri1 + tri1;
            float tempMed = 0;
            int tempMax = 0, tempMin = 100, tempReg = 0;

            for (int x = tri1; x < tri2; x++)
            {
                if (temp[x] != -100)
                {
                    tempMed = tempMed + temp[x];
                    tempReg++;
                }

                if (temp[x] > tempMax)
                    tempMax = temp[x];

                if ((temp[x] < tempMin) && (temp[x] != -100))
                    tempMin = temp[x];
            }

            txtTempReg.Text = tempReg.ToString();

            tempMed = tempMed / tempReg;

            txtTempMedia.Text = Math.Round(tempMed, 2).ToString();
            txtTempMax.Text = tempMax.ToString();
            txtTempMin.Text = tempMin.ToString();

            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int tri1 = temp.Length / 4;
            int tri2 = tri1 + tri1;
            int tri3 = tri2 + tri1;
            float tempMed = 0;
            int tempMax = 0, tempMin = 100, tempReg = 0;

            for (int x = tri2; x < tri3; x++)
            {
                if (temp[x] != -100)
                {
                    tempMed = tempMed + temp[x];
                    tempReg++;
                }

                if (temp[x] > tempMax)
                    tempMax = temp[x];

                if ((temp[x] < tempMin) && (temp[x] != -100))
                    tempMin = temp[x];
            }

            txtTempReg.Text = tempReg.ToString();

            tempMed = tempMed / tempReg;

            txtTempMedia.Text = Math.Round(tempMed, 2).ToString();
            txtTempMax.Text = tempMax.ToString();
            txtTempMin.Text = tempMin.ToString();

            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int tri1 = temp.Length / 4;
            int tri2 = tri1 + tri1;
            int tri3 = tri2 + tri1;
            int tri4 = tri2 + tri2;
            float tempMed = 0;
            int tempMax = 0, tempMin = 100, tempReg = 0;

            for (int x = tri3; x < tri4; x++)
            {
                if (temp[x] != -100)
                {
                    tempMed = tempMed + temp[x];
                    tempReg++;
                }

                if (temp[x] > tempMax)
                    tempMax = temp[x];

                if ((temp[x] < tempMin) && (temp[x] != -100))
                    tempMin = temp[x];
            }

            txtTempReg.Text = tempReg.ToString();

            tempMed = tempMed / tempReg;

            txtTempMedia.Text = Math.Round(tempMed, 2).ToString();
            txtTempMax.Text = tempMax.ToString();
            txtTempMin.Text = tempMin.ToString();

            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
    }
}
