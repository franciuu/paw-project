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
    public partial class ModificaProdusForm : Form
    {
        private ProdusRepository _repository = new ProdusRepository();
        private Produs _produs;
        public ModificaProdusForm(Produs produs)
        {
            InitializeComponent();
            _produs = produs;
            idTextBox.Text = _produs.Id.ToString();
            denumireTextBox.Text = _produs.Denumire;
            descriereRichTextBox.Text = _produs.Descriere;
            pretTextBox.Text = _produs.Pret.ToString();
            cantitateTextBox.Text = _produs.Stoc.ToString();
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
            _produs.Id = Convert.ToInt16(idTextBox.Text);
            if (isEmpty(denumireTextBox.Text))
                throw new FormatException("Specificati denumirea!");
            _produs.Denumire = denumireTextBox.Text;
            if (isEmpty(descriereRichTextBox.Text))
                throw new FormatException("Specificati descrierea!");
            _produs.Descriere = descriereRichTextBox.Text;
            if (isEmpty(pretTextBox.Text))
                throw new FormatException("Specificati pretul!");
            if (!double.TryParse(pretTextBox.Text, out var pret))
                throw new FormatException("Introduceti un pret corespunzator!");
            _produs.Pret = pret;
            if (isEmpty(cantitateTextBox.Text))
                throw new FormatException("Specificati cantitatea!");
            if (!int.TryParse(cantitateTextBox.Text, out var cant))
                throw new FormatException("Introduceti o cantitate corespunzatoare!");
            _produs.Stoc = cant;
            _repository.ModificaProdus(_produs);
            Close();
        }
    }
}
