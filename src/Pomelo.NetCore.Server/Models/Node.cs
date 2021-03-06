﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pomelo.NetCore.Server.Models
{
    public class Node
    {
        public Guid Id { get; set; }

        [MaxLength(64)]
        public string Alias { get; set; }

        public string IP { get; set; }

        public string PrivateKey { get; set; }
    }
}
