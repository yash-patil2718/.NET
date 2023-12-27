namespace DAL;
using MySql.Data.MySqlClient;

public static class Connectivity
{
    private static MySqlConnection conn=null;
    // private Connectivity(){
        // conn = new MySqlConnection();
        // conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac9;password=welcome;database=employee";
    // }
    public static MySqlConnection getConn(){
        return conn;
    }
    public static MySqlConnection getConnection(){
        Connectivity connect; 
        if(conn==null){
        String connstr= "server=192.168.10.150;port=3306;user=dac9;password=welcome;database=employee";
            conn = new MySqlConnection(connstr);
            // connect = new Connectivity();
            // return connect.getConn();
            return conn;
        }
        return conn;
    }


}
