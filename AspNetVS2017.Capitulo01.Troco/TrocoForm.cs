using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            decimal troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C");

            //ToDo: refatorar para usar vetor e for.

            int moedas100 = (int)troco;

            moedasListView.Items[0].Text = moedas100.ToString();

            troco %= 1;

            int moedas050 = (int)(troco / 0.5m);

            moedasListView.Items[1].Text = moedas050.ToString();

            troco %= 0.5m;

            int moedas025 = (int)(troco / 0.25m);

            moedasListView.Items[2].Text = moedas025.ToString();

            troco %= 0.25m;

            int moedas010 = (int)(troco / 0.10m);

            moedasListView.Items[3].Text = moedas010.ToString();

            troco %= 0.10m;

            int moedas005 = (int)(troco / 0.05m);

            moedasListView.Items[4].Text = moedas005.ToString();

            troco %= 0.05m;

            int moedas001 = (int)(troco / 0.01m);

            moedasListView.Items[5].Text = moedas001.ToString();

            troco %= 0.01m;

        }
    }
}