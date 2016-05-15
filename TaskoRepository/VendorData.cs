using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskoCore;

namespace TaskoRepository
{
    public static class VendorData
    {
        public static Vendor GetVendor(string vendorId)
        {
            Vendor objVendor = new Vendor();
            List<SqlParameter> objParameters = new List<SqlParameter>();

            objParameters.Add(SqlHelper.CreateParameter("@pVendorId", DbType.Binary, BinaryConverter.ConvertStringToByte(vendorId)));

            IDataReader reader = SqlHelper.GetDataReader("dbo.usp_GetVendorDetails", objParameters.ToArray());
            if (reader.Read())
            {
                objVendor.Id = BinaryConverter.ConvertByteToString((byte[])reader["VENDOR_ID"]);
                objVendor.Name = reader["NAME"].ToString();
                objVendor.MobileNumber = reader["MOBILE_NUMBER"].ToString();
            }

            reader.Close();

            return objVendor;
        }

        public static Order GetOrderDetails(string orderId)
        {
            Order objOrder = new Order();
            List<SqlParameter> objParameters = new List<SqlParameter>();

            objParameters.Add(SqlHelper.CreateParameter("@pOrderId", DbType.String, orderId));
            IDataReader reader = SqlHelper.GetDataReader("dbo.usp_GetOrderDetails", objParameters.ToArray());
            if (reader.Read())
            {
                objOrder.OrderId = reader["ORDER_ID"].ToString();                
                objOrder.VendorServiceID = BinaryConverter.ConvertByteToString((byte[])reader["VENDOR_SERVICE_ID"]);
                objOrder.CustomerId = BinaryConverter.ConvertByteToString((byte[])reader["CUSTOMER_ID"]); 
            }

            reader.Close();

            return objOrder;
        }
    }
}
