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
    public class ProdusRepository
    {
        public List<Produs> ObtineProduse()
        {
            List<Produs> produse = new List<Produs>();
            using (var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"select * from p_produse";

                using (var command = new OracleCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var produs = new Produs();
                        produs.Id = Convert.ToInt32(dataReader["ID_PRODUS"].ToString());
                        produs.Denumire = dataReader["DENUMIRE_PRODUS"].ToString();
                        produs.Descriere = dataReader["DESCRIERE"].ToString();
                        produs.Pret = Convert.ToDouble(dataReader["PRET"].ToString());
                        produs.Stoc = Convert.ToInt32(dataReader["STOC"].ToString());

                        produse.Add(produs);
                    }
                }
            }
            return produse;
        }

        public void AdaugaProdus(Produs produs)
        {
            using(var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();

                var getQuery = "select seq_produse_id.nextval from dual";
                using (var getCommand = new OracleCommand(getQuery, connection))
                {
                    var id = Convert.ToInt32(getCommand.ExecuteScalar());
                    produs.Id = id;
                }

                string query = $"insert into p_produse (id_produs, denumire_produs, descriere, pret, stoc) values (:id, :denumire, :descriere, :pret, :stoc)";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("id", produs.Id);
                    command.Parameters.Add("denumire", produs.Denumire);
                    command.Parameters.Add("descriere", produs.Descriere);
                    command.Parameters.Add("pret", produs.Pret);
                    command.Parameters.Add("stoc", produs.Stoc);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ModificaProdus(Produs produs)
        {
            using (var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"update p_produse set denumire_produs = :denumire, descriere = :descriere, pret = :pret, stoc = :stoc where id_produs = {produs.Id}";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("denumire", produs.Denumire);
                    command.Parameters.Add("descriere", produs.Descriere);
                    command.Parameters.Add("pret", produs.Pret);
                    command.Parameters.Add("stoc", produs.Stoc);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void StergeProdus(Produs produs)
        {
            using (var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"delete from p_produse where id_produs = {produs.Id}";

                using (var command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
