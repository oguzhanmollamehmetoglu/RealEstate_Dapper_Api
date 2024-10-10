namespace EntityLayer.Concrete
{
    public class AppUser
    {
        public int UserID { get; set; }
        public int UserRole { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImageUrl { get; set; }
    }
}