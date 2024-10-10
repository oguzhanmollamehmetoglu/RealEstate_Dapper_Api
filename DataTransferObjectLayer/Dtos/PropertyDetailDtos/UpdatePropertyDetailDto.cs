
namespace DataTransferObjectLayer.Dtos.PropertyDetailDtos
{
    public class UpdatePropertyDetailDto
    {
        public int PropertyDetailsID { get; set; }

        public int BedRoomCount { get; set; }

        public int PropertySize { get; set; }

        public int BathCount { get; set; }

        public int RoomCount { get; set; }

        public int GarageSize { get; set; }

        public int BuildYear { get; set; }

        public decimal Price { get; set; }

        public string Location { get; set; }

        public string VideoUrl { get; set; }

        //public int PropertyID { get; set; }

        public bool PropertyDetailsStatus { get; set; }
    }
}