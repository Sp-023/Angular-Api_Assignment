using Angular_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Api.Services
{
 public   interface Interface_ApiService
    {
        public IEnumerable<Happytravels> GetAll();
        Happytravels Getbyid(int id);
        Happytravels Addtravel(Happytravels ht);

        Happytravels UpdateTravels(Happytravels ht,int id);
        Happytravels DeleteTravels(int id);

       
    }
}
