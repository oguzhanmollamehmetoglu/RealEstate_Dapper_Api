namespace DataTransferObjectLayer.Dtos.EstateAgentDtos
{
    public class ResultDashboardLastPropertyDto
    {
        public int PropertyID { get; set; }

        public string Title { get; set; }

        public string SlugUrl { get; set; }

        public decimal Price { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string CategoryName { get; set; }

        public DateTime AdvertisementDate { get; set; }
    }
}