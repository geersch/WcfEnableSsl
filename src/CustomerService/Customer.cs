using System;
using System.Runtime.Serialization;

namespace CustomerService
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}