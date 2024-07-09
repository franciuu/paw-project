using Oracle.ManagedDataAccess.Client;
using Proiect_Vanzari.Entities;
using Seminarul9.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vanzari.Repositories
{
    public class ClientRepository
    {
        public List<Client> ObtineClienti()
        {
            List<Client> clienti = new List<Client>();
            using(var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"select * from p_clienti";

                using(var command = new OracleCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var client = new Client();
                        client.Id = Convert.ToInt32(dataReader["ID_CLIENT"].ToString());
                        client.Nume = dataReader["NUME"].ToString();
                        client.Prenume = dataReader["PRENUME"].ToString();
                        client.DataNastere = dataReader.GetDateTime(dataReader.GetOrdinal("DATA_NASTERE"));
                        client.Email = dataReader["EMAIL"].ToString();
                        client.Telefon = dataReader["TELEFON"].ToString();

                        clienti.Add(client);
                    }
                }
            }
            return clienti;
        }

        public void AdaugaClient(Client client)
        {
            using (var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();

                var getQuery = "select seq_client_id.nextval from dual";
                using (var getCommand = new OracleCommand(getQuery, connection))
                {
                    var id = Convert.ToInt32(getCommand.ExecuteScalar());
                    client.Id = id;
                }

                var query = $"insert into p_clienti(id_client, nume, prenume, data_nastere, telefon, email) values (:id, :nume, :prenume, :data, :telefon, :email)";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("id", client.Id);
                    command.Parameters.Add("nume", client.Nume);
                    command.Parameters.Add("prenume", client.Prenume);
                    command.Parameters.Add("data", client.DataNastere);
                    command.Parameters.Add("telefon", client.Telefon);
                    command.Parameters.Add("email", client.Email);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void ModificaClient(Client client)
        {
            using (var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"update p_clienti set nume = :nume, prenume = :prenume, data_nastere = :data, telefon = :telefon, email = :email where id_client = {client.Id}";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("nume", client.Nume);
                    command.Parameters.Add("prenume", client.Prenume);
                    command.Parameters.Add("data", client.DataNastere);
                    command.Parameters.Add("telefon", client.Telefon);
                    command.Parameters.Add("email", client.Email);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void StergeClient(Client client)
        {
            using(var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"delete from p_clienti where id_client = {client.Id}";

                using(var command = new OracleCommand(query , connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
