using MySQl.Data.Client;
namespace DAL;

public static class DBManager{
    public static void Insert(Product p){
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150; port=3306; user=dac9; password=welcome;database=dac9";
        conn.Open();
        string query = "insert into product11 values(@pid,@pname,@pqty,@prate)";
        MySqlCommand command = new  MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@pid",pid);
        command.Parameters.AddWithValue("@pname",pnm);
        command.Parameters.AddWithValue("@pqty",pqt);
        command.Parameters.AddWithValue("@prate",prte);
        command.ExecuteNonQuery();
        conn.Close();
    }
}