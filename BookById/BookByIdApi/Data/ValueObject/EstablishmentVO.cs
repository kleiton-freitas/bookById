using System;
using BookByIdApi.Model;

namespace BookByIdApi.Data.ValueObject
{
    public class EstablishmentVO
    {
        public int EstablishmentID { get; set; }
        public string CnpjCpf { get; set; }

        public string CompanyName { get; set; }
        public string CompanyFancyName { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string SocialNetwork { get; set; }   
        public string Logo { get; set; }
        public string CoverPhoto { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }

        public EstablishmentVO()
        {
        }
    }
}
