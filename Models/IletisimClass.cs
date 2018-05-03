using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArduinoLedYonetimi.Models.Concrate;

namespace ArduinoLedYonetimi.Models
{
    class IletisimClass
    {
        EFUsers efUsers = new EFUsers();

        public int UserLogin(string kadi,string sifre)
        {
            Users u = new Users();
            u.Kadi = kadi;
            u.Sifre = sifre;
            int a = efUsers.UserLogin(u);
            return a;
        }
    }
}
