using System;
namespace BookByIdApi.Data.ValueObject
{
    public class AddressVO
    {
        public int AddressID { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string UF { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public int UserID { get; set; }

    }
}
