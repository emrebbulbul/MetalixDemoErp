﻿using System.ComponentModel.DataAnnotations;

namespace MetalixDemoErp.Entitiy
{
    public class DangilNo
    {
        [Key]
        public int DangilId { get; set; }
        public int Dangilno { get; set; }
        public DateTime DateTime { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set;}
    }
}
