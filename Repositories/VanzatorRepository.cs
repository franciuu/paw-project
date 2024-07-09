using Oracle.ManagedDataAccess.Client;
using Proiect_Vanzari.Entities;
using Seminarul9.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Vanzari.Repositories
{
    public class VanzatorRepository
    {
        public List<Vanzator> ObtineVanzatori()
        {
            List<Vanzator> vanzatori = new List<Vanzator>();
            using(var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"select * from p_vanzatori";

                using (var command = new OracleCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var vanzator = new Vanzator();  
                        vanzator.Id = Convert.ToInt32(dataReader["ID_VANZATOR"].ToString());
                        vanzator.Nume = dataReader["NUME"].ToString();
                        vanzator.Prenume = dataReader["PRENUME"].ToString();
                        vanzator.Telefon = dataReader["TELEFON"].ToString();
                        vanzator.Salariu = Convert.ToDouble(dataReader["SALARIU"].ToString());
                        vanzator.Sex = dataReader["SEX"].ToString();
                        vanzator.DataNasterii = dataReader.GetDateTime(dataReader.GetOrdinal("DATA_NASTERE"));

                        vanzatori.Add(vanzator);
                    }
                }
            }
            return vanzatori;   
        }
        public void AdaugaVanzator(Vanzator vanzator)
        {
            using (var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var getQuery = "select seq_vanzator_id.nextval from dual";
                using(var getCommand = new OracleCommand(getQuery, connection))
                {
                    var id = Convert.ToInt32(getCommand.ExecuteScalar());
                    vanzator.Id = id;
                }
                var query = $"insert into p_vanzatori (id_vanzator, nume, prenume, telefon, salariu, sex, data_nastere) values (:id, :nume, :prenume, :telefon, :salariu, :sex, :data)";

                using(var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("id", vanzator.Id);
                    command.Parameters.Add("nume", vanzator.Nume);
                    command.Parameters.Add("prenume", vanzator.Prenume);
                    command.Parameters.Add("telefon", vanzator.Telefon);
                    command.Parameters.Add("salariu", vanzator.Salariu);
                    command.Parameters.Add("sex", vanzator.Sex);
                    command.Parameters.Add("data", vanzator.DataNasterii);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ModificaVanzator(Vanzator vanzator)
        {
            using(var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"update p_vanzatori set nume = :nume, prenume = :prenume, telefon = :telefon, salariu = :salariu, sex = :sex, data_nastere = :data where id_vanzator = {vanzator.Id}";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("nume", vanzator.Nume);
                    command.Parameters.Add("prenume", vanzator.Prenume);
                    command.Parameters.Add("telefon", vanzator.Telefon);
                    command.Parameters.Add("salariu", vanzator.Salariu);
                    command.Parameters.Add("sex", vanzator.Sex);
                    command.Parameters.Add("data", vanzator.DataNasterii);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void StergeVanzator(Vanzator vanzator)
        {
            using (var connection = new OracleConnection(Constants.ConnectionString))
            {
                connection.Open();
                var query = $"delete from p_vanzatori where id_vanzator = {vanzator.Id}";

                using (var command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
