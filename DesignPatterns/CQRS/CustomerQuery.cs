using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{
    public class CustomerQuery
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public decimal Billamount { get; set; }


        public int NumberOfVisits { get; set; }
        public string Behaviour { get; set; }
    }
}
