using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RepesitoReal.Models
{
    public class Country
    {
        [Key]
        //[Required]
        public string name { get; set; }
        
        public string capital { get; set; }
        
        public int population { get; set; }
        public double latlng { get; set; }
        
        public string timezones { get; set; }
        
        public string currencies { get; set; }
        
        public string flag { get; set; }
        
    }
}