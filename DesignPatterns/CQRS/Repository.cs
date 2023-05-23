using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{
    public class Repository
    {
        public void Save(CustomerCommand obj) { }
        public List<CustomerQuery>? Read() 
        {
            return null;
        }
    }
}
