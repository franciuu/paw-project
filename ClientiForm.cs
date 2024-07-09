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
    public partial class ClientiForm : Form
    {
        private ClientRepository _repository = new ClientRepository();
        private ComandaRepository _repo = new ComandaRepository();
        public ClientiForm()
        {
            InitializeComponent();
            clientiDataGridView.AutoGenerateColumns = true;
            clientiDataGridView.DataSource = _repository.ObtineClienti();
            AddButtonColumn("Edit", "Edit client", "EditColumn");
            AddButtonColumn("Delete", "Delete client", "DeleteColumn");
        }
        public void AddButtonColumn(string buttonText, string headerText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.UseColumnTextForButtonValue = true;
            column.Text = buttonText;
            column.HeaderText = headerText;
            column.Name = columnName;
            clientiDataGridView.Columns.Add(column);
        }
        private void adaugaButton_Click(object sender, EventArgs e)
        {
            var adaugaClientForm = new AdaugaClientForm();
            adaugaClientForm.StartPosition = FormStartPosition.CenterParent;
            adaugaClientForm.ShowDialog();
            clientiDataGridView.DataSource = _repository.ObtineClienti();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientiGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            var client = (Client)grid.Rows[e.RowIndex].DataBoundItem;
            if(columnName == "DeleteColumn")
            {
                var result = MessageBox.Show($"Confirmati stergerea clientului cu id-ul {client.Id}? Stergerea va duce la anularea tuturor comenzilor asociate.", "Confirmati actiunea", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    _repo.StergeComandaClient(client);
                    _repository.StergeClient(client);
                    clientiDataGridView.DataSource = _repository.ObtineClienti();
                } 
            }
            else if(columnName == "EditColumn")
            {
                var modificaClientForm = new ModificaClientForm(client);
                modificaClientForm.StartPosition = FormStartPosition.CenterParent;
                modificaClientForm.ShowDialog();
                clientiDataGridView.DataSource = _repository.ObtineClienti();
            }

        }
    }
}
