using Oracle.ManagedDataAccess.Client;
using Proiect_Vanzari.Entities;
using Seminarul9.Repositories;
using System;
using System.Collections.Generic;

public class ComandaRepository
{
    public List<Comanda> ObtineComenzi()
    {
        List<Comanda> comenzi = new List<Comanda>();
        using (var connection = new OracleConnection(Constants.ConnectionString))
        {
            connection.Open();
            var query = $"select * from p_comenzi";

            using (var command = new OracleCommand(query, connection))
            {
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    var comanda = new Comanda();
                    comanda.Id = Convert.ToInt32(dataReader["ID_COMANDA"]);
                    comanda.Data = Convert.ToDateTime(dataReader["DATA"]);
                    comanda.Modalitate = dataReader["MODALITATE"].ToString();
                    comanda.Id_Client = Convert.ToInt32(dataReader["ID_CLIENT"]);
                    comanda.Id_Vanzator = Convert.ToInt32(dataReader["ID_VANZATOR"]);

                    comenzi.Add(comanda);
                }
            }
        }
        return comenzi;
    }

    public List<Produs> ObtineProduseComanda(int idComanda)
    {
        var produseComanda = new List<Produs>();
        using (var connection = new OracleConnection(Constants.ConnectionString))
        {
            connection.Open();
            var query = @"select p.* from p_rand_comenzi rc
                          join p_produse p on rc.id_produs = p.id_produs
                          where rc.id_comanda = :idComanda";

            using (var command = new OracleCommand(query, connection))
            {
                command.Parameters.Add("idComanda", idComanda);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    var produs = new Produs();
                    produs.Id = Convert.ToInt32(dataReader["ID_PRODUS"]);
                    produs.Denumire = dataReader["DENUMIRE_PRODUS"].ToString();
                    produs.Descriere = dataReader["DESCRIERE"].ToString();
                    produs.Pret = Convert.ToDouble(dataReader["PRET"]);
                    produs.Stoc = Convert.ToInt32(dataReader["STOC"]);
                   
                    produseComanda.Add(produs);
                }
            }
        }
        return produseComanda;
    }
    public void AdaugaComanda(Comanda comanda)
    {
        using (var connection = new OracleConnection(Constants.ConnectionString))
        {
            connection.Open();

            string query = $"insert into p_comenzi (id_comanda, data, modalitate, id_client, id_vanzator) values (:id, :data, :modalitate, :id_client, :id_vanzator)";
            using (var command = new OracleCommand(query, connection))
            {
                command.Parameters.Add("id", comanda.Id);
                command.Parameters.Add("data", comanda.Data);
                command.Parameters.Add("modalitate", comanda.Modalitate);
                command.Parameters.Add("id_client", comanda.Id_Client);
                command.Parameters.Add("id_vanzator", comanda.Id_Vanzator);

                command.ExecuteNonQuery();
            }

            foreach (var produs in comanda.Produse)
            {
                string query2 = $"insert into p_rand_comenzi (id_comanda, id_produs) values (:id_comanda, :id_produs)";
                using (var command = new OracleCommand(query2, connection))
                {
                    command.Parameters.Add("id_comanda", comanda.Id);
                    command.Parameters.Add("id_produs", produs.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
    public void StergeComandaClient(Client client)
    {
        using (var connection = new OracleConnection(Constants.ConnectionString))
        {
            connection.Open();
            string query = $"delete from p_rand_comenzi where id_comanda in (select id_comanda from p_comenzi where id_client = {client.Id})";
            using (var commandDeleteRandComenzi = new OracleCommand(query, connection))
            {
                commandDeleteRandComenzi.ExecuteNonQuery();
            }

            string query2 = $"delete from p_comenzi where id_client = {client.Id}";
            using (var commandDeleteComenzi = new OracleCommand(query2, connection))
            {
                commandDeleteComenzi.ExecuteNonQuery();
            }
        }
    }

    public void StergeComandaVanzator(Vanzator vanzator)
    {
        using (var connection = new OracleConnection(Constants.ConnectionString))
        {
            connection.Open();
            string query = $"delete from p_rand_comenzi where id_comanda in (select id_comanda from p_comenzi where id_vanzator = {vanzator.Id})";
            using (var commandDeleteRandComenzi = new OracleCommand(query, connection))
            {
                commandDeleteRandComenzi.ExecuteNonQuery();
            }

            string query2 = $"delete from p_comenzi where id_vanzator = {vanzator.Id}";
            using (var commandDeleteComenzi = new OracleCommand(query2, connection))
            {
                commandDeleteComenzi.ExecuteNonQuery();
            }
        }
    }

    public void StergeComandaProdus(Produs produs)
    {
        using (var connection = new OracleConnection(Constants.ConnectionString))
        {
            connection.Open();
            string querySelect = $"select id_comanda from p_rand_comenzi where id_produs = {produs.Id}";
            using (var command = new OracleCommand(querySelect, connection))
            {
                var dataReader = command.ExecuteReader();
                var comenziDeSters = new List<int>();
                while (dataReader.Read())
                {
                    comenziDeSters.Add(Convert.ToInt32(dataReader["id_comanda"]));
                }

                string query = "delete from p_rand_comenzi where id_comanda = :idComanda";
                foreach (var comandaId in comenziDeSters)
                {
                    using (var commandDeleteRandComenzi = new OracleCommand(query, connection))
                    {
                        commandDeleteRandComenzi.Parameters.Add("idComanda", comandaId);
                        commandDeleteRandComenzi.ExecuteNonQuery();
                    }
                }

                string query2 = "delete from p_comenzi where id_comanda = :idComanda";
                foreach (var comandaId in comenziDeSters)
                {
                    using (var commandDeleteComenzi = new OracleCommand(query2, connection))
                    {
                        commandDeleteComenzi.Parameters.Add("idComanda", comandaId);
                        commandDeleteComenzi.ExecuteNonQuery();
                    }
                }
            }
        }
    }


}