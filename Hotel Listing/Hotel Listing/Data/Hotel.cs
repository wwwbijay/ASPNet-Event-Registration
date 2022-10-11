﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Listing.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        [ForeignKey(nameof(Country))]
        public string Country { get; set; } 
        public int CountryId { get; set; }
    }
}
