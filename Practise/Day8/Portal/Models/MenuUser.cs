namespace Portal;
using BLL;
using DAL;
using BOL;
using MySql.Data.MySqlClient;

class MenuDriven{
    // Businesslayer blayer = new Businesslayer();
    MySqlDataReader reader =Businesslayer.showEmployee();
    
}