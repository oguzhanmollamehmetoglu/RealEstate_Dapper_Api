namespace DataTransferObjectLayer.Dtos.PropertyDtos
{
    public class ResultPropertyDtos
    {
        public int PropertyID { get; set; }
        public int AppUserID { get; set; }
        public string Title { get; set; }
        public string SlugUrl { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Type { get; set; }
        public string Coverİmage { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string CategoryName { get; set; }
        public bool DealOfTheDay { get; set; }
        public bool PropertyStatus { get; set; }
        //public bool PropertyDetailsStatus { get; set; }
        public DateTime AdvertisementDate { get; set; }
        public bool AdvertPropertyStatus { get; set; }
    }
}