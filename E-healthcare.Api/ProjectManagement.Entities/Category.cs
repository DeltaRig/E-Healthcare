using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthcare.Entities
{
    public class Category : BaseEntity
    {
        public long ID { get; set; }

        public string Name { get; set; }
    }
}
