namespace BLL;
using DAL;
using MySql.Data.MySqlClient;

public class Businesslayer
{
    static MySqlConnection myconn = Connectivity.getConnection();

    public static List<Employee> showEmployee(){
        List<Employee> e1 = new List<>();
        string query = "select * from emp";
        myconn.Open();
        MySqlCommand command = new MySqlCommand(query, myconn);
        MySqlDataReader reader = command.ExecuteReader();
        while(reader.Read()){
            Employee e = new Employee(int.Parse(reader["Pid"].ToString()),reader["Pname"].ToString(),reader["Padd"].ToString(),double.Parse(reader["Pmobile"].ToString()));
            e1.Add(e);
        }
        return e1;
    }
}
