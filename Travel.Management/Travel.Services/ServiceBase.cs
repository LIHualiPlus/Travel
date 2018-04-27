using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DataBase;

namespace Travel.Services
{
    public class ServiceBase: TravelEntities
    {
        public void adduser() {
            TravelEntities dbcontext = new TravelEntities();
            var user = new User_Ship();
            user.Id = Guid.NewGuid();
            user.Name = "ddfals";
            dbcontext.User_Ship.Add(user);

        }
    }
}
