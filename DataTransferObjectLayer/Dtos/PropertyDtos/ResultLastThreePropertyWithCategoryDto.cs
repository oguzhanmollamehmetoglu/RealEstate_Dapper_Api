namespace DataTransferObjectLayer.Dtos.PropertyDtos
{
    public class ResultLastThreePropertyWithCategoryDto
    {
        public int PropertyID { get; set; }

        public string Title { get; set; }

        public string SlugUrl { get; set; }

        public decimal Price { get; set; }

        public string City { get; set; }

        public string Coverİmage { get; set; }

        public string Description { get; set; }

        public string District { get; set; }

        public int PropertyCategory { get; set; }

        public string CategoryName { get; set; }

        public DateTime AdvertisementDate { get; set; }

        public bool AdvertPropertyStatus { get; set; }
    }
}