using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskoCore;
using TaskoRepository;

namespace TaskoTestClient
{
    class Program
    {
        static void Main(string[] args)
        { 
            /// Get Order Details
            Order objOrder = VendorData.GetOrderDetails("TASKO1000");
            if(objOrder!=null)
            {
                Console.WriteLine("OrderID : " + objOrder.OrderId);
                Console.WriteLine("VendorServiceID : " + objOrder.VendorServiceID);
                Console.WriteLine("CustomerID : " + objOrder.CustomerId);
                Console.ReadLine();
            }

            //// GetVendor details
            Vendor objVendor = VendorData.GetVendor("083660EDD2E10147A128B8CA0C2FA46C");
            if (objVendor != null)
            {
                Console.WriteLine("Id : " + objVendor.Id);
                Console.WriteLine("Name : " + objVendor.Name);
                Console.WriteLine("MobileNumber : " + objVendor.MobileNumber);
                Console.ReadLine();
            }
        }
    }
}
