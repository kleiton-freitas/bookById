using System;
namespace BookByIdApi.Model
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceValue { get; set; }

        public Service()
        {
        }
    }
}
