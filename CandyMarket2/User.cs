using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMarket2
{
    class User
    {
        readonly DatabaseContext _db;
        public string Name { get; set; }

        public User(string name, DatabaseContext db)
        {
            Name = name;
            _db = db;
        }

        public void AddCandy(Candy candy)
        {
            _db.SaveNewCandy(Name, candy);
        }

        //todo: method to give candy to other users
    }
}
