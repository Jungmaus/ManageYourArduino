using ArduinoLedYonetimi.Models.Abstract;
using ArduinoLedYonetimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoLedYonetimi.Models.Concrate
{
    class EFUsers : IUsers
    {
        public int UserLogin(Users u)
        {
            using (var db = new UserDBEntities1())
            {
                Users user = db.Users.FirstOrDefault(x => x.Kadi == u.Kadi && x.Sifre == u.Sifre);
                if (user != null)
                {
                    user.LastLogin = DateTime.Now;
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 1;
                }
                else return 0;
            }  
        }
    }
}
