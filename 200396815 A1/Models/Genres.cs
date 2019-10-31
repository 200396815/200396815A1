﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200396815_A1.Models
{
    public class Genres
    {
        [Key]
        [Required]
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}