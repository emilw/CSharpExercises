using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_7.BaseballPlayer
{
    public class PlayerRepository : IPlayerRepository
    {
        //This should be in app.config for a real application
        private string connString = @"Server=ARNE\SQLEXPRESS;Database=Baseball;Trusted_Connection=True";
        private DataTable GetTable(SqlCommand sqlCommand)
        {
            SqlConnection connection = new SqlConnection(connString);
            sqlCommand.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
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

            var dataTable = GetTable(new SqlCommand("Select PlayerId, FirstName, LastName, BattingAverage From Players"));

            return PerformSimpleMap(dataTable);
        }

        public IList<Player> GetPlayersBySearchParameters(string lastName, decimal battingAverageFrom, decimal battingAverageTo)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText = String.Format("Select PlayerId, FirstName, LastName, BattingAverage From Players", lastName);
            if (!String.IsNullOrEmpty(lastName))
            {
                sqlCommand.CommandText = String.Format("{0} Where LastName Like @lastName", sqlCommand.CommandText);
                sqlCommand.Parameters.AddWithValue("@lastName", lastName + "%");
            }
            if (battingAverageFrom != 0 || battingAverageTo != 1)
            {
                if (sqlCommand.Parameters.Count == 0)
                    sqlCommand.CommandText = String.Format("{0} Where ", sqlCommand.CommandText);
                else
                    sqlCommand.CommandText = String.Format("{0} And ", sqlCommand.CommandText);

                sqlCommand.CommandText = String.Format("{0} BattingAverage Between @battingAverageFrom And @battingAverageTo", sqlCommand.CommandText, battingAverageFrom, battingAverageTo);
                sqlCommand.Parameters.Add("@battingAverageFrom", SqlDbType.Decimal).Value = battingAverageFrom;
                sqlCommand.Parameters.Add("@battingAverageTo", SqlDbType.Decimal).Value = battingAverageTo;
            }

            var dataTable = GetTable(sqlCommand);
            return PerformSimpleMap(dataTable);
        }
    }
}
