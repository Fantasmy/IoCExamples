using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlUsed
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
