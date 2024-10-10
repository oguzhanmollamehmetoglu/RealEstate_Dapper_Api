
namespace DataTransferObjectLayer.Dtos.AddressDtos
{
    public class GetByIdAddressDto
    {
        public int AddressID { get; set; }
        public string AddressFull { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}