using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ITestimonialService
    {
        Task<List<Testimonial>> TGetAllTestimonial();

        Task TCreateTestimonial(Testimonial testimonial);

        Task TDeleteTestimonial(int id);

        Task TUpdateTestimonial(Testimonial testimonial);

        Task<Testimonial> TGetTestimonial(int id);
    }
}