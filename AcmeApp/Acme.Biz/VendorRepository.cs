using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        ///     Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            var vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }

            return vendor;
        }

        /// <summary>
        /// Retrieves this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor {VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com"});
                vendors.Add(new Vendor {VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com"});
            }

            for (var i = 0; i < vendors.Count; i++) Console.WriteLine(vendors[i]);

            foreach (var vendor in vendors)
            {
//                Console.WriteLine(vendor);
            }

            return vendors;
        }

        public IEnumerable<Vendor> RetrieveAll()
        {
            vendors = new List<Vendor>();
            vendors.Add(new Vendor {VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com"});
            vendors.Add(new Vendor {VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com"});
            vendors.Add(new Vendor {VendorId = 12, CompanyName = "EFG Ltd", Email = "efg@efg.com"});
            vendors.Add(new Vendor {VendorId = 17, CompanyName = "HIJ AG", Email = "hij@hij.com"});
            vendors.Add(new Vendor {VendorId = 22, CompanyName = "Amalgamated Toys", Email = "a@abc.com"});
            vendors.Add(new Vendor {VendorId = 28, CompanyName = "Toy Blocks Inc", Email = "blocks@abc.com"});
            vendors.Add(new Vendor {VendorId = 31, CompanyName = "Home Products Inc", Email = "home@abc.com"});
            vendors.Add(new Vendor {VendorId = 35, CompanyName = "Car Toys", Email = "car@abc.com"});
            vendors.Add(new Vendor {VendorId = 42, CompanyName = "Toys for Fun", Email = "fun@abc.com"});
            return vendors;
        }


        /// <summary>
        /// Retrieves all of the approved vendors, one at a time
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            // Get the data from the database
            this.Retrieve();

            foreach (var vendor in vendors)
            {
                Console.WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }


        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            // Call the database to retrieve the value
            // If no value is returned, return the default value
            var value = defaultValue;
            return value;
        }

        /// <summary>
        ///     Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}