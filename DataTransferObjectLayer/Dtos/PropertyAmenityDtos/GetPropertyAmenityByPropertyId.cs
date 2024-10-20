
namespace DataTransferObjectLayer.Dtos.PropertyAmenityDtos
{
    public class GetPropertyAmenityByPropertyId
    {
        public int PropertyAmenityID { get; set; }
        public int PropertyID { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}