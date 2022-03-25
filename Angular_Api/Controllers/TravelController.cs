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
    [ApiController]
    [Route("api/[controller]")]
    
    
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
        [Route("api/Travel/Addt")]*/
        public  Happytravels Addt(Happytravels ht)
        {
            return con.Addtravel(ht);
        }
        

        /*public Happytravels updatet(int id)
        {
            return  con.Getbyid(id);
            
        }*/
        [HttpPut]
        /*[Route("[action]")]
        [Route("api/Travel/UpdateT")]*/
        public Happytravels UpdateT(Happytravels ut,int id)
        {
            return con.UpdateTravels(ut,id);
        }
        [HttpDelete]
        public Happytravels Delete(int id)
        {
            return con.DeleteTravels(id);
        }
    }
}
