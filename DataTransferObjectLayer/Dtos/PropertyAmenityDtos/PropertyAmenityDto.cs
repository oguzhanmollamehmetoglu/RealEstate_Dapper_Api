namespace DataTransferObjectLayer.Dtos.PropertyAmenityDtos
{
    public class PropertyAmenityDto
    {
        public int PropertyAmenityID { get; set; }

        public string Title { get; set; }

        public int PropertyID { get; set; }

        public int AmenityID { get; set; }

        public bool Status { get; set; }
    }
}