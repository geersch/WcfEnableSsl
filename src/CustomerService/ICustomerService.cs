using System.Collections.Generic;
using System.ServiceModel;

namespace CustomerService
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        IEnumerable<Customer> GetCustomers();
    }
}
