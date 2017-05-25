using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_6.BaseballPlayer
{
    public class PlayerRepository : IPlayerRepository
    {
        //This should be in app.config for a real application
        private string connString = @"Server=ARNE\SQLEXPRESS;Database=Baseball;Trusted_Connection=True";
        private DataTable GetTable(string query)
        {
            SqlConnection connection = new SqlConnection(connString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        private IList<Player> PerformSimpleMap(DataTable dataTable)
        {
            var result = new List<BaseballPlayer.Player>();
            foreach (DataRow row in dataTable.Rows)
            {
                var player = new BaseballPlayer.Player()
                {
                    PlayerId = Convert.ToInt32(row["PlayerId"]),
                    LastName = row["LastName"].ToString(),
                    FirstName = row["FirstName"].ToString(),
                    BattingAverage = Convert.ToDecimal(row["BattingAverage"])
                };

                result.Add(player);
            }

            return result;
        }
        public IList<Player> GetAllPlayers()
        {

            var dataTable = GetTable("Select PlayerId, FirstName, LastName, BattingAverage From Players");

            return PerformSimpleMap(dataTable);
        }

        public IList<Player> GetPlayersByLastName(string lastName)
        {
            var query = String.Format("Select PlayerId, FirstName, LastName, BattingAverage From Players Where LastName Like '{0}%'", lastName);
            var dataTable = GetTable(query);
            return PerformSimpleMap(dataTable);
        }
    }
}
