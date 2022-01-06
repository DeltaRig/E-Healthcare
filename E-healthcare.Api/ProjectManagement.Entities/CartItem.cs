using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthcare.Entities
{
    public class CartItem : BaseEntity
    {
        public long CartID { get; set; }

        public long ProductID { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }
    }
}
