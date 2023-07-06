using DbConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class UserMessaging : IUserMessaging
    {
        private readonly IDatabase _database;
        public UserMessaging(IDatabase database)
        {
            _database = database;

        }
        public UserMessaging()
        {
            

        }
        public string dbdata()
        {
            //Database d = new Database();
            var res = _database.Info();
            //var res = d.Info();
            return res;
        }
        public string GetWelcomeUserMsg(string userID)
        {
            string output = _database.WelcomeMsg(userID);
            return output;
        }
    }
}
