using System;
using System.Collections.Generic;
using Acme.Common;

namespace Acme.Biz
{
    /// <summary>
    ///     Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        /// <summary>
        ///     Calculates the suggested retail price
        /// </summary>
        /// <param name="markupPercent">Percent used to mark up the cost.</param>
        /// <returns></returns>
        public OperationResult<decimal> CalculateSuggestedPrice(decimal markupPercent)
        {
            var message = "";
            if (markupPercent <= 0)
                message = "Invalid markup percentage";
            else if (markupPercent < 10) message = "Below recommended markup percentage";

            var value = Cost + Cost * markupPercent / 100;
            var operationalResult = new OperationResult<decimal>(value, message);
            return operationalResult;
        }

        public override string ToString()
        {
            return ProductName + " (" + ProductId + ")";
        }

        #region Constructors

        public Product()
        {
            #region Lists and Arrays
            //            var colorOptions = new List<string>();
            //            colorOptions.Add("Red");
            //            colorOptions.Add("Espresso");
            //            colorOptions.Add("White");
            //            colorOptions.Add("Navy");
            //            colorOptions.Insert(2, "Purple");
            //            colorOptions.Remove("White");
            var colorOptions = new List<string>() {"Red", "Espresso", "White", "Navy"};

            Console.WriteLine(colorOptions);

            //            var colorOptions = new string[4];
            //            colorOptions[0] = "Red";
            //            colorOptions[1] = "Espresso";
            //            colorOptions[2] = "White";
            //            colorOptions[3] = "Navy";
            //            string[] colorOptions = {"Red", "Espresso", "White", "Navy"};
            //            var brownIndex = Array.IndexOf(colorOptions, "Espresso");
            //            colorOptions.SetValue("Blue", 3);
            //            for (int i = 0; i < colorOptions.Length; i++)
            //            {
            //                colorOptions[i] = colorOptions[i].ToLower();
            //            }
            //
            //            foreach (var color in colorOptions)
            //            {
            //                Console.WriteLine($"The color is {color}");
            //            }
            #endregion
//            var states = new Dictionary<string, string>();
//            states.Add("CA", "California");
//            states.Add("WA", "Washington");
//            states.Add("NY", "New York");
            var states = new Dictionary<string, string>()
                {{"CA", "California"}, {"WA", "Washington"}, {"NY", "New York"}};

            Console.WriteLine(states);
        }

        public Product(int productId,
            string productName,
            string description) : this()
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;
        }

        #endregion

        #region Properties

        public DateTime? AvailabilityDate { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }

        private string productName;

        public string ProductName
        {
            get
            {
                var formattedValue = productName?.Trim();
                return formattedValue;
            }
            set
            {
                if (value.Length < 3)
                    ValidationMessage = "Product Name must be at least 3 characters";
                else if (value.Length > 20)
                    ValidationMessage = "Product Name cannot be more than 20 characters";
                else
                    productName = value;
            }
        }

        private Vendor productVendor;

        public Vendor ProductVendor
        {
            get
            {
                if (productVendor == null) productVendor = new Vendor();

                return productVendor;
            }
            set => productVendor = value;
        }

        public string ValidationMessage { get; private set; }

        #endregion
    }
}