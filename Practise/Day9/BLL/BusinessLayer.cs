namespace BLL;
using BOL;
using MySql.Data.MySqlClient;
using DAL;
public class BusinessLayer
{
    static MySqlConnection conn = Connect.getConnection();

    public static void InsertData(int EmployeeId1, string EmployeeName1, string CompanyName1){
        string query = "insert into RegisterEmployee values (@EmployeeId,@EmployeeName,@CompanyName)";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query,conn);
        command.Parameters.AddWithValue("@EmployeeId",EmployeeId1);
        command.Parameters.AddWithValue("@EmployeeName",EmployeeName1);
        command.Parameters.AddWithValue("@CompanyName",CompanyName1);
        command.ExecuteNonQuery();
        conn.Close();
    }

    public static Employee Login(int EmployeeId, string EmployeeName){
        string query = "select * from RegisterEmployee where EmployeeId= @EmployeeId and EmployeeName = @EmployeeName";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@EmployeeId",EmployeeId);
        command.Parameters.AddWithValue("@EmployeeName",EmployeeName);
        MySqlDataReader reader = command.ExecuteReader();
        // if(reader==null){
        //     return false;
        //     conn.Close();
        // }
        Employee e=null;
        bool flag = false;
        while(reader.Read()){
            e = new Employee(reader["CompanyName"].ToString(),reader["EmployeeName"].ToString(),int.Parse(reader["EmployeeId"].ToString()));
            flag = true;
        }
        if(flag){
            conn.Close();
            return e;
        }
        conn.Close();
        return e;



       
    }
}
