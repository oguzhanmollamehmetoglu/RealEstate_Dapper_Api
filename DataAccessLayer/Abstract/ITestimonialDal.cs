using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ITestimonialDal
    {
        Task<List<Testimonial>> GetAllTestimonial();

        Task CreateTestimonial(Testimonial testimonial);

        Task DeleteTestimonial(int id);

        Task UpdateTestimonial(Testimonial testimonial);

        Task<Testimonial> GetTestimonial(int id);
    }
}