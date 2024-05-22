﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Price per night")]
        [Range(10, 10000)]
        public double Price { get; set; }
        [Range(10, 10000)]

        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        [NotMapped]
        public IFormFile? Image {  get; set; }
        [Display(Name = "ImageUrl")]
        public string? ImageUrl { get; set; }
        public DateTime? Created_Data { get; set; }
        public DateTime? Updated_Data { get;set; }
    }
}
