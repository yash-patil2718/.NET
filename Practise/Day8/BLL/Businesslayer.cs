namespace BLL;
using DAL;
using BOL;
using MySql.Data.MySqlClient;

public class Businesslayer
{
    static MySqlConnection myconn = Connectivity.getConnection();

    public static List<Employee> showEmployee(){
        // try{
            List<Employee> e1 = new List<Employee>();
        string query = "select * from employee";
        myconn.Open();
        MySqlCommand command = new MySqlCommand(query, myconn);
        MySqlDataReader reader = command.ExecuteReader();
        while(reader.Read()){
            Employee e = new Employee(int.Parse(reader["Pid"].ToString()),reader["Pname"].ToString(),reader["Padd"].ToString(),long.Parse(reader["Pmobile"].ToString()));
            e1.Add(e);
        }
        // myconn.Close();
        return e1;
        // }
        // catch(Exception e){
        //     Console.WriteLine("Error happened");
        // }
        // finally{
             myconn.Close();
        // } 
    }
}
