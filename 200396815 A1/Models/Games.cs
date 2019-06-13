using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200396815_A1.Models
{
    public class Games
    {
        public int GamesID { get; set; }
        public int Price { get; set; }

        public string Name { get; set; }
        [Required]
     
        public string Description { get; set; }
        [Required]
        
        public string MinimumRequirements { get; set; }
        public string Publisher { get; set; }
        [Required]
      
        public string Developer { get; set; }
        [Required]
      
        public string Genres { get; set; }
        [Required]
     
        public string Reviews { get; set; }




    }
}