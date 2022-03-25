using Angular_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Api.Services
{
    public class Class_ApiService : Interface_ApiService
    {
        public TravelsContext con;
        public Class_ApiService(TravelsContext Con)
        {
            con = Con;
        }

        public Happytravels Addtravel(Happytravels ht)
        {
            con.happytravels.Add(ht);
            con.SaveChanges();
            return ht;
        }

        public IEnumerable<Happytravels> GetAll()
        {
            return con.happytravels.ToList();
        }

        public Happytravels UpdateTravels(Happytravels ht, int id)
        {
            con.Entry(ht).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            con.SaveChanges();
            return ht;
        }
        public Happytravels DeleteTravels(int id)
        {
            var dd = con.happytravels.Find(id);
            con.happytravels.Remove(dd);
            con.SaveChanges();
            return dd;
        }

        public Happytravels Getbyid(int id)
        {
            var res = con.happytravels.FirstOrDefault(n => n.Id == id);
            return res;
        }
    }
}
