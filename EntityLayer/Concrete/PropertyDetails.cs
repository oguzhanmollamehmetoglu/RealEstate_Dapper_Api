namespace EntityLayer.Concrete
{
    public class PropertyDetails
    {
        public int PropertyDetailsID { get; set; }
        public int PropertySize { get; set; }
        public int PropertyID { get; set; }
        public int BedRoomCount { get; set; }
        public int BathCount { get; set; }
        public int RoomCount { get; set; }
        public int GarageSize { get; set; }
        public int BuildYear { get; set; }
        public string Location { get; set; }
        public string VideoUrl { get; set; }
        public bool PropertyDetailsStatus { get; set; }
    }
}