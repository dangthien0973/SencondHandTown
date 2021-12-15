using System;
using System.Collections.Generic;

namespace APISencondHandTown.Models
{

    public class ProductModel
    {

  
    
        private string ProductName = String.Empty;
        private int Price;
        private int PriceSale;
        private int ProductDetailsId;
        private int Amount;



        public ProductModel()
        {

        }

        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public int Price1 { get => Price; set => Price = value; }
        public int PriceSale1 { get => PriceSale; set => PriceSale = value; }
        public int ProductDetailsId1 { get => ProductDetailsId; set => ProductDetailsId = value; }
        public int Amount1 { get => Amount; set => Amount = value; }


    }

}
