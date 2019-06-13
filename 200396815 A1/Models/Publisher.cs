﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200396815_A1.Models
{
    public class Publisher
    {
        [Key]
        [Required]
        public int PublisherId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Website { get; set; }
    }
}