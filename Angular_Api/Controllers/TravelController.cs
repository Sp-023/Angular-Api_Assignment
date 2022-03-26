using Angular_Api.Models;
using Angular_Api.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class TravelController : ControllerBase
    {
        private Interface_ApiService con;
        public TravelController(Interface_ApiService Con)
        {
            con = Con;
        }
        [HttpGet]
        /*[Route("[action]")]
        [Route("api/Travel")]*/
        public IEnumerable<Happytravels> GetAll()
        {
        return con.GetAll();
        }
        [HttpPost]
        /*[Route("[action]")]
        [Route("api/Travel")]*/
        public  Happytravels Addt(Happytravels ht)
        {
            return con.Addtravel(ht);
        }
        

        /*public Happytravels updatet(int id)
        {
            return  con.Getbyid(id);
            
        }*/
        [HttpPut("{id}")]
       /* [Route("[action]")]
        [Route("api/Travel")]*/
        public Happytravels UpdateT(int id,Happytravels ut)
        {
            return con.UpdateTravels(id, ut);
        }
        [HttpDelete("{id}")]
        /*[Route("[action]")]
        [Route("api/Travel")]*/
        public Happytravels Delete(int id)
        {
            return con.DeleteTravels(id);
        }
    }
}
