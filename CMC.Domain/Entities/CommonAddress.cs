﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public abstract class CommonAddress
    {
        [Required(ErrorMessage ="Field cannot be left empty. Please check all fields and fill the vacant")]
        [MaxLength(5, ErrorMessage ="Building Number cannot exceed 5 characters ")]
        public string? BuildingNumber { get; set; }
        [Required(ErrorMessage = "Field cannot be left empty. Please check all fields and fill the vacant")]
        [MaxLength(20, ErrorMessage = "Street Name cannot exceed 20 characters ")]
        public string? StreetName { get; set; }
        [MaxLength(15, ErrorMessage = "Landmark cannot exceed 15 characters ")]
        public string? Landmark { get; set; }
        [Required(ErrorMessage = "Field cannot be left empty. Please check all fields and fill the vacant")]
        [MaxLength(15, ErrorMessage = "Locality cannot exceed 15 characters ")]
        public string? Locality { get; set; }
        [Required(ErrorMessage = "Field cannot be left empty. Please check all fields and fill the vacant")]
        [MaxLength(15, ErrorMessage = "City name cannot exceed 15 characters ")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Field cannot be left empty. Please check all fields and fill the vacant")]
        [MaxLength(10, ErrorMessage = "Postcode value cannot exceed 10 characters ")]
        public int PostCode { get; set; }
        [Required(ErrorMessage = "Field cannot be left empty. Please check all fields and fill the vacant")]
        [MaxLength(15, ErrorMessage = "State name cannot exceed 15 characters ")]
        public string? State { get; set; }
        [Required(ErrorMessage = "Field cannot be left empty. Please check all fields and fill the vacant")]
        [MaxLength(15, ErrorMessage = "Country name cannot exceed 15 characters ")]
        public string? Country { get; set; }
    }
}
