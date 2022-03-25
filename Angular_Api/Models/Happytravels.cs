using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Angular_Api.Models
{
    public partial class Happytravels
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Phoneno { get; set; }
        public string TravelFrom { get; set; }
        public string TravelTo { get; set; }
    }
}
