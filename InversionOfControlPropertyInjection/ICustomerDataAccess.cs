using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlPropertyInjection
{
    public interface ICustomerDataAccess
    {
        string GetCustomerData(int id);
    }
}
