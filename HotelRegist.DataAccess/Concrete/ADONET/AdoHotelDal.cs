using HotelRegist.DataAccess.Abstract;
using HotelRegist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DataAccess.Concrete.ADONET
{
    public class AdoHotelDal : IHotelDal
        //databaseleri yanlış onları migrationsdan sonra düzelt
    {
        public void Add(Hotel t)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlCommand cmd =
            new SqlCommand("Insert Into Hotels(HotelName,Price,Capasity,CategoryID) Values (@HotelName,@Price,@Capasity,@CategoryID)", connection))
            {
                cmd.Parameters.AddWithValue("HotelName", t.HotelName);
                cmd.Parameters.AddWithValue("Price", t.Price);
                cmd.Parameters.AddWithValue("Capasity", t.Capasity);
                cmd.Parameters.AddWithValue("CategoryId", t.CategoryId);

                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        public void Delete(Hotel t)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlCommand cmd =
            new SqlCommand("Delete from Hotels where Id=@Id", connection))
            {
                cmd.Parameters.AddWithValue("Id",t.Id);


                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Hotel> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = new SqlCommand("Select *from Hotels", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Hotel> hotels = new List<Hotel>();
            while (reader.Read())
            {
                Hotel hotel = new Hotel()
                {
                    Id = Convert.ToInt32(reader[0]),
                    HotelName = reader[1].ToString(),
                    Price = Convert.ToInt32(reader[2]),
                    Capasity = Convert.ToInt32(reader[3]),
                    CategoryId = Convert.ToInt32(reader[4])

                };

                hotels.Add(hotel);
            }
            reader.Close();
            connection.Close();
            return hotels;
        }

        public void Update(Hotel t)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlCommand cmd =
            new SqlCommand("Update  Hotels set HotelName=@HotelName,Price=@Price,Capasity=@Capasity,CategoryID=@CategoryID where HotelName=@HotelName,Price=@Price,Capasity=@Capasity,CategoryID=@CategoryID ", connection))
            {
                cmd.Parameters.AddWithValue("HotelName", t.HotelName);
                cmd.Parameters.AddWithValue("Price", t.Price);
                cmd.Parameters.AddWithValue("Capasity", t.Capasity);
                cmd.Parameters.AddWithValue("CategoryId", t.CategoryId);

                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
