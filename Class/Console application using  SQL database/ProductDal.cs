using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Database ile ilgili Insert, Update, Delete fonksiyonlari buraya yazilir.
namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\ProjectsV13;initial catalog=ETrade;integrated security=true");//Baglanti nesnesini olusturduk
        public List<Product> GetAll()
        {
            if (_connection.State == ConnectionState.Closed)//Eger baglanti kapali ise 
            {
                _connection.Open();//Baglantiyi kuruyoruz
            }

            SqlCommand command = new SqlCommand("Select * from Products", _connection);//Sorguyu connection'a gonderiyor

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    id = Convert.ToInt32(reader["id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        //2.senaryo: DataTable hali
        public DataTable GetAll2()
        {
            //initial catalog: baglanmak istedigimiz veri tabani.
            //Basina @ koymamizin sebebi: devamindaki tirnak icerisinde yazilan seyleri tamamiyle stringg olarak kabul et.
            //Uzaktan bir veri tabanin baglanmak istersek integrated security = false yap.
            if (_connection.State == ConnectionState.Closed)//Eger baglanti kapali ise 
            {
                _connection.Open();//Baglantiyi kuruyoruz
            }

            SqlCommand command = new SqlCommand("Select * from Products", _connection);//Sorguyu connection'a gonderiyor

            SqlDataReader reader = command.ExecuteReader();

            //Gunumuzde DataTable pek kullanilmamaktadir.
            //Nedeni: memory acisindan pahali bir nesnedir, ve serilestirme ozelligi bulunmaz. (Serilestirme ne demek bilmiyorum?)
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();

            return dataTable;
        }

        public void Add(Product product)
        {
            if (_connection.State == ConnectionState.Closed)//Eger baglanti kapali ise 
            {
                _connection.Open();//Baglantiyi kuruyoruz
            }

            SqlCommand command = new SqlCommand("Insert into Products Values(@Name, @UnitPrice, @StockAmount)", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);

            command.ExecuteNonQuery();//kayit oldu mu olmadi mi diye kullanilabilir.
            _connection.Close();
        }

        public void Update(Product product)
        {
            if (_connection.State == ConnectionState.Closed)//Eger baglanti kapali ise 
            {
                _connection.Open();//Baglantiyi kuruyoruz
            }

            SqlCommand command = new SqlCommand("Update Products set Name=@Name, StockAmount=@StockAmount, UnitPrice=@UnitPrice where Id=@id", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@id", product.id);

            command.ExecuteNonQuery();//kayit oldu mu olmadi mi diye kullanilabilir.
            _connection.Close();
        }

        public void Delete(int id)
        {
            if (_connection.State == ConnectionState.Closed)//Eger baglanti kapali ise 
            {
                _connection.Open();//Baglantiyi kuruyoruz
            }

            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();//kayit oldu mu olmadi mi diye kullanilabilir.
            command.ExecuteNonQuery();//kayit oldu mu olmadi mi diye kullanilabilir.
            _connection.Close();
        }
    }
}