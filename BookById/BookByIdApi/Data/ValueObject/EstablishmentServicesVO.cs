using System;
namespace BookByIdApi.Data.ValueObject
{
    public class EstablishmentServicesVO
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceValue { get; set; }
        public int EstablishmentID { get; set; }
    }
}
