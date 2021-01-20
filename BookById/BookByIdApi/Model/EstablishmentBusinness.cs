using System;
namespace BookByIdApi.Model
{
    public class EstablishmentBusinness
    {
        public int EstablishmentBusinnesID { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public DateTime OpeningDay { get; set; }
        public DateTime ClosingDay { get; set; }
        public string AboutUs { get; set; }

        public EstablishmentBusinness()
        {
        }
    }
}
