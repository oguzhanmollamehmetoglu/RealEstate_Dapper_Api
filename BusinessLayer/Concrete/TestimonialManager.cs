using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public async Task TCreateTestimonial(Testimonial testimonial)
        {
            await _testimonialDal.CreateTestimonial(testimonial);
        }

        public async Task TDeleteTestimonial(int id)
        {
            await _testimonialDal.DeleteTestimonial(id);
        }

        public async Task<List<Testimonial>> TGetAllTestimonial()
        {
            return await _testimonialDal.GetAllTestimonial();
        }

        public async Task<Testimonial> TGetTestimonial(int id)
        {
            return await _testimonialDal.GetTestimonial(id);
        }

        public async Task TUpdateTestimonial(Testimonial testimonial)
        {
            await _testimonialDal.UpdateTestimonial(testimonial);
        }
    }
}