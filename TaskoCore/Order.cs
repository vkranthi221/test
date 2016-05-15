using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TaskoCore
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public string OrderId { get; set; }

        [DataMember]
        public string VendorServiceID { get; set; }

        [DataMember]
        public string CustomerId { get; set; }
    }
}
