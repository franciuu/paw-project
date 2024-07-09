using Proiect_Vanzari.Entities;
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
    public partial class AdaugareProdusForm : Form
    {
        private ProdusRepository _repository = new ProdusRepository();
        public AdaugareProdusForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool isEmpty(string textBox)
        {
            return textBox == string.Empty;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            var produs = new Produs();
            if (isEmpty(denumireTextBox.Text))
                throw new FormatException("Specificati denumirea!");
            produs.Denumire = denumireTextBox.Text;
            if (isEmpty(descriereRichTextBox.Text))
                throw new FormatException("Specificati descrierea!");
            produs.Descriere = descriereRichTextBox.Text;
            if (isEmpty(pretTextBox.Text))
                throw new FormatException("Specificati pretul!");
            if (!double.TryParse(pretTextBox.Text, out var pret))
                throw new FormatException("Introduceti un pret corespunzator!");
            produs.Pret = pret;
            if (isEmpty(cantitateTextBox.Text))
                throw new FormatException("Specificati cantitatea!");
            if (!int.TryParse(cantitateTextBox.Text, out var cant))
                throw new FormatException("Introduceti o cantitate corespunzatoare!");
            produs.Stoc = cant;
            _repository.AdaugaProdus(produs);
            Close();
        }
    }
}
