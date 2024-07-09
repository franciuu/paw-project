using Proiect_Vanzari.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Vanzari
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
        }

        private void clientiButton_Click(object sender, EventArgs e)
        {
            var clientiForm = new ClientiForm();
            clientiForm.StartPosition = FormStartPosition.CenterParent;
            clientiForm.ShowDialog();
        }

        private void comenziButton_Click(object sender, EventArgs e)
        {
            var comenziForm = new ComenziForm();
            comenziForm.StartPosition = FormStartPosition.CenterParent;
            comenziForm.ShowDialog();
        }

        private void produseButton_Click(object sender, EventArgs e)
        {
            var produseForm = new ProduseForm();
            produseForm.StartPosition = FormStartPosition.CenterParent;
            produseForm.ShowDialog();
        }

        private void vanzatoriButton_Click(object sender, EventArgs e)
        {
            var vanzatoriForm = new VanzatoriForm();
            vanzatoriForm.StartPosition = FormStartPosition.CenterParent;
            vanzatoriForm.ShowDialog();
        }
    }
}
