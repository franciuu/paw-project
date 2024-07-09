using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_Vanzari.Entities;
using Proiect_Vanzari.Repositories;

namespace Proiect_Vanzari
{
    public partial class ComenziForm : Form
    {
        private ComandaRepository _repository = new ComandaRepository();
        public ComenziForm()
        {
            InitializeComponent();
            comenziDataGridView.AutoGenerateColumns = true;
            comenziDataGridView.DataSource = _repository.ObtineComenzi();
            ConfigureDataGridViewProduse();

            comenziDataGridView.SelectionChanged += comenziDataGridView_SelectionChanged;
        }
        private void ConfigureDataGridViewProduse()
        {
            produseDataGridView.AutoGenerateColumns = false;

            var column1 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Denumire",
                DataPropertyName = "Denumire"
            };
            var column2 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Descriere",
                DataPropertyName = "Descriere"
            };
            var column3 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Pret",
                DataPropertyName = "Pret"
            };
            produseDataGridView.Columns.Add(column1);
            produseDataGridView.Columns.Add(column2);
            produseDataGridView.Columns.Add(column3);
        }

        private void comenziDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (comenziDataGridView.SelectedRows.Count > 0)
            {
                var comanda = (Comanda)comenziDataGridView.SelectedRows[0].DataBoundItem;
                var produseComandate = _repository.ObtineProduseComanda(comanda.Id);

                produseDataGridView.DataSource = produseComandate;
            }
            else
            {
                produseDataGridView.DataSource = null;
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            var adaugaComanda = new AdaugaComandaForm();
            adaugaComanda.StartPosition = FormStartPosition.CenterParent;
            adaugaComanda.ShowDialog();
            comenziDataGridView.DataSource = _repository.ObtineComenzi();
        }
    }

}
