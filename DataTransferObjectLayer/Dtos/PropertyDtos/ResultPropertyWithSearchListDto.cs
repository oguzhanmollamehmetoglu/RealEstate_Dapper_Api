namespace DataTransferObjectLayer.Dtos.PropertyDtos
{
    public class ResultPropertyWithSearchListDto
    {
        public int PropertyID { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Type { get; set; }

        public string Coverİmage { get; set; }

        public string Address { get; set; }

        public string CategoryName { get; set; }

        public bool DealOfTheDay { get; set; }

        public bool AdvertPropertyStatus { get; set; }
    }
}