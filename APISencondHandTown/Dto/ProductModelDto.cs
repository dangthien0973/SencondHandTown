using System;

namespace APISencondHandTown.Dto
{

    public class ProdductModelDto
    {

        private string NameProduct = String.Empty;
        private int Price = 0;
        private int PriceSale = 0;
        private int Amount = 0;
        private string SourceOrigin = String.Empty;
        private string Descriptions = String.Empty;

        public ProdductModelDto()
        {
        }

        public string NameProduct1 { get => NameProduct; set => NameProduct = value; }
        public int Price1 { get => Price; set => Price = value; }
        public int PriceSale1 { get => PriceSale; set => PriceSale = value; }
        public int Amount1 { get => Amount; set => Amount = value; }
        public string SourceOrigin1 { get => SourceOrigin; set => SourceOrigin = value; }
        public string Descriptions1 { get => Descriptions; set => Descriptions = value; }
    }

}
