﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPBX.DAL.Models
{
    public class Email
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string? EmailAddress { get; set; }
    }
}
