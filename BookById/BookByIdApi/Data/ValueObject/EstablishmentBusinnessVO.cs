using System;
namespace BookByIdApi.Data.ValueObject
{
    public class EstablishmentBusinnessVO
    {
        public int EstablishmentBusinnessID { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string OpeningDay { get; set; }
        public string ClosingDay { get; set; }
        public string AboutUs { get; set; }
        public int EstablishmentID { get; set; }

    }
}
