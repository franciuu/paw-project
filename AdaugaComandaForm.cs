using Proiect_Vanzari.Entities;
using Proiect_Vanzari.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_Vanzari
{
    public partial class AdaugaComandaForm : Form
    {
        private ComandaRepository _repository = new ComandaRepository();
        private List<Produs> _produseDisponibile;

        public AdaugaComandaForm()
        {
            InitializeComponent();
            IncarcaProduseDisponibile();
            ConfigureDataGridViewProduse();
        }

        private void IncarcaProduseDisponibile()
        {
            var produsRepository = new ProdusRepository();
            _produseDisponibile = produsRepository.ObtineProduse();

            produseDataGridView.DataSource = _produseDisponibile.Select(p => new { p.Id, p.Denumire, p.Descriere, p.Pret }).ToList();
            produseDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void ConfigureDataGridViewProduse()
        {
            produseDataGridView.AutoGenerateColumns = false;
            var selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.Name = "SelectColumn";
            selectColumn.HeaderText = "Select";
            selectColumn.DisplayIndex = 0;

            produseDataGridView.Columns.Add(selectColumn);
        }

        private bool isEmpty(string textBox)
        {
            return textBox == string.Empty;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            var comanda = new Comanda();
            comanda.Data = dataTimePicker.Value;
            if (modalitateComboBox.SelectedIndex == -1)
                throw new FormatException("Specificati modalitatea!");
            comanda.Modalitate = modalitateComboBox.Text;
            if (isEmpty(idClientTextBox.Text))
                throw new FormatException("Specificati id-ul clientului!");
            if (!int.TryParse(idClientTextBox.Text, out var idc))
                throw new FormatException("Introduceti un id valid!");
            comanda.Id_Client = idc;
            if (isEmpty(idVanzatorTextBox.Text))
                throw new FormatException("Specificati id-ul vanztorului!");
            if (!int.TryParse(idVanzatorTextBox.Text, out var idv))
                throw new FormatException("Specificati id-ul valid!");
            comanda.Id_Vanzator = idv;
            comanda.Produse = new List<Produs>();

            foreach (DataGridViewRow row in produseDataGridView.Rows)
            {
                if (row.Cells["SelectColumn"].Value != null && (bool)row.Cells["SelectColumn"].Value) 
                {
                    var produs = _produseDisponibile[row.Index];
                    comanda.Produse.Add(produs);
                }
            }

            _repository.AdaugaComanda(comanda);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void produseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (produseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
            {
                produseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)produseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
