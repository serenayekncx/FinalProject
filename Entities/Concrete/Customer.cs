using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public int ContactName { get; set; }
        public int CompanyName { get; set; }
        public int City { get; set; }
    }


}
