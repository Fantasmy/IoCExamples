using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example: Inject Dependency
//As you can see, CustomerService class creates and injects 
//CustomerDataAccess object into CustomerBusinessLogic class. 
//Thus, CustomerBusinessLogic class need not create an object 
//of CustomerDataAccess using new keyword or using factory class. 
//The calling class (CustomerService) creates and sets appropriate 
//DataAccess class to the CustomerBusinessLogic class. 
//This way CustomerBusinessLogic and CustomerDataAccess class 
//become more loosely coupled classes.


namespace InversionOfControlConstructorInjection
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }
}
