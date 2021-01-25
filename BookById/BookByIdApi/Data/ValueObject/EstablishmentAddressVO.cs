using System;
namespace BookByIdApi.Data.ValueObject
{
    public class EstablishmentAddressVO
    {
        public int EstablishmentAddressID { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string UF { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public int EstablishmentID { get; set; }
    }
}
