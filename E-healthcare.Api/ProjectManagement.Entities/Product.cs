using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EHealthcare.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
        }

        public string Name { get; set; }

        public string CompanyName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public string ImageUrl { get; set; }

        public string Uses { get; set; }

        public string ExpireDate { get; set; }
    }
}
