using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Zapravka
{
    public partial class Form1 : Form
    {
        private int[] price;
        private int i;
        public Form1()
        {
            InitializeComponent();

            string[] benzins = { "AИ-98", "АИ-95", "АИ-92" };
            cmbBenzin.Items.AddRange(benzins);
            price = new int[] { 66, 54, 50 };
            cmbBenzin.SelectedIndexChanged += CmbBenzin_SelectedIndexChanged;
            cmbBenzin.SelectedIndex = 0;
        }

        private void CmbBenzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbZena_Benzin.Text = price[cmbBenzin.SelectedIndex].ToString();
        }

        private void rdbKol_CheckedChanged(object sender, EventArgs e)
        {
            txbLitri.Enabled = true;
            txbRub.Enabled = false;
            txbRub.Text = "";
        }

        private void rdbSumm_CheckedChanged(object sender, EventArgs e)
        {
            txbLitri.Enabled = false;
            txbLitri.Text = "";
            txbRub.Enabled = true;
        }

        private void chbChotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (chbChotDog.Checked == true)
            {
                txbCol_ChotDog.Enabled = true;
            }
            else
            {
                txbCol_ChotDog.Enabled = false;
                txbCol_ChotDog.Text = "";
            }
        }

        private void chbGamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGamburger.Checked == true)
            {
                txbCol_Gamburg.Enabled = true;
            }
            else
            {
                txbCol_Gamburg.Enabled = false;
                txbCol_Gamburg.Text = "";
            }
        }

        private void chbFri_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFri.Checked == true)
            {
                txbCol_Fri.Enabled = true;
            }
            else
            {
                txbCol_Fri.Enabled = false;
                txbCol_Fri.Text = "";
            }
        }

        private void chbKola_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKola.Checked == true)
            {
                txbCol_Kola.Enabled = true;
            }
            else
            {
                txbCol_Kola.Enabled = false;
                txbCol_Kola.Text = "";
            }
        }

        private void txbLitri_TextChanged(object sender, EventArgs e)
        {
            if (txbLitri.Text != "")
            {
                lblKOplate_Avtozapr.Text = (int.Parse(txbLitri.Text) * int.Parse(txbZena_Benzin.Text)).ToString();
                lblRubIliLitri.Text = "руб.";
            }
            else
                lblKOplate_Avtozapr.Text = "0,00";
        }

        private void txbGrn_TextChanged(object sender, EventArgs e)
        {
            if (txbRub.Text != "")
            {
                grbKOplate_Avtozapr.Text = "К выдаче";
                lblRubIliLitri.Text = "л.";
                double summa = (double.Parse(txbRub.Text) / double.Parse(txbZena_Benzin.Text));
                lblKOplate_Avtozapr.Text = $"{summa:F2}";
            }
            else
                lblKOplate_Avtozapr.Text = "0,00";
        }

        private void txbCol_ChotDog_TextChanged(object sender, EventArgs e)
        {
            Poschitat_KOplate_MiniKafe();
        }

        private void txbCol_Gamburg_TextChanged(object sender, EventArgs e)
        {
            Poschitat_KOplate_MiniKafe();
        }

        private void txbCol_Fri_TextChanged(object sender, EventArgs e)
        {
            Poschitat_KOplate_MiniKafe();
        }

        private void txbCol_Kola_TextChanged(object sender, EventArgs e)
        {
            Poschitat_KOplate_MiniKafe();
        }
        private void Poschitat_KOplate_MiniKafe()
        {
            double summ = 0;
            //Карочь тут какая-то проблема с подсчетов вывода в приложение и я не хочу это делать

            if (txbCol_ChotDog.Text != "")
                summ += double.Parse(txbCol_ChotDog.Text) * double.Parse(txbZena_ChotDog.Text);
            if (txbCol_Gamburg.Text != "")
                summ += double.Parse(txbCol_Gamburg.Text) * double.Parse(txbZena_Gamburg.Text);
            if (txbCol_Fri.Text != "")
                summ += double.Parse(txbCol_Fri.Text) * double.Parse(txbZena_Fri.Text);
            if (txbCol_Kola.Text != "")
                summ += double.Parse(txbCol_Kola.Text) * double.Parse(txbZena_Kola.Text);
            lblKOplate_MiniKafe.Text = summ.ToString();
        }


            private void btnPoschitat_Click(object sender, EventArgs e)
        {
            i = 0;
            double summ = double.Parse(lblKOplate_MiniKafe.Text);
            if (lblRubIliLitri.Text == "руб.")
            {
                summ += double.Parse(lblKOplate_Avtozapr.Text);
            }
            else
            {
                summ += int.Parse(txbRub.Text);
            }
            lblKOplate_Vsego.Text = summ.ToString();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 10)
            {
                DialogResult res = MessageBox.Show("Очистить форму?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    timer.Stop();
                    double VsegoZaDen = double.Parse(lblVsegoZaDen.Text) + double.Parse(lblKOplate_Vsego.Text);
                    cmbBenzin.SelectedIndex = 0;
                    rdbSumm.Checked = false;
                    rdbKol.Checked = false;
                    txbLitri.Enabled = false;
                    txbLitri.Text = "";
                    txbRub.Enabled = false;
                    txbRub.Text = "";
                    chbChotDog.Checked = false;
                    chbGamburger.Checked = false;
                    chbFri.Checked = false;
                    chbKola.Checked = false;
                    lblKOplate_Avtozapr.Text = "0,00";
                    lblKOplate_MiniKafe.Text = "0,00";
                    lblKOplate_Vsego.Text = "0,00";
                    lblRubIliLitri.Text = "Rub.";                   
                    lblVsegoZaDen.Text = VsegoZaDen.ToString();
                }
                else
                {
                    i = 0;
                }
           
            
            }
        }

        private void cmbBenzin_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txbCol_ChotDog_Leave(object sender, EventArgs e)
        {
           
        }

        private void txbZena_Gamburg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}