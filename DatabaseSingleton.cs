using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Design_Patterns___Singleton
{
    public class DatabaseSingleton
    {
        
        private static DatabaseSingleton _instance;

        private string _dataSource;
        private string _dataBase;
        private bool _integratedSecurity;
        private string _userId;
        private string _password;
        private bool _encrypt;
        private bool _trustServerCertificate;

        private DatabaseSingleton() 
        {
            _dataSource = "localhost";
            _dataBase = "ManageAccount";
            _integratedSecurity = false;
            _userId = "sa";
            _password = "MedSQLserver91*";
            _encrypt = true;
            _trustServerCertificate = true;   
        }

        public static DatabaseSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseSingleton();
            }
            return _instance;
        }

        public void Query(string sqlQuery) 
        {
        }
    }
}
