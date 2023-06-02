using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYönetimSistemi
{
    internal class VeritabaniIslemleri
    {
        private string _connectionString;

        public VeritabaniIslemleri(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool IsTCKNUnique(string tckn)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // Veritabanından TC kimlik numaralarını kontrol etmek için sorguyu hazırlayın
                string query = "SELECT COUNT(*) FROM YourTable WHERE TCKN=@tckn";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tckn", tckn);
                connection.Open();

                // Sorguyu çalıştırın ve sonucu alın
                int count = (int)command.ExecuteScalar();

                // TC Kimlik numarası benzersiz olmalı, bu yüzden eğer sorgu sonucu 0 ise
                // bu TC Kimlik numarası benzersizdir
                return count == 0;
            }
        }
    }
}
