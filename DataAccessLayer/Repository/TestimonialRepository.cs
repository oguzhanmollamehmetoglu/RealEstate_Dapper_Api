using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class TestimonialRepository : ITestimonialDal
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateTestimonial(Testimonial testimonial)
        {
            string query = "insert into Testimonial(NameSurname,Title,Comment,Status) values(@nameSurname,@title,@comment,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@nameSurname", testimonial.NameSurname);
            parameters.Add("@title", testimonial.Title);
            parameters.Add("@comment", testimonial.Comment);
            parameters.Add("@status", testimonial.Status);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteTestimonial(int id)
        {
            string query = "Delete From Testimonial Where TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<Testimonial>> GetAllTestimonial()
        {
            string query = "Select * From Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Testimonial>(query);
                return values.ToList();
            }
        }

        public async Task<Testimonial> GetTestimonial(int id)
        {
            string query = "Select * From Testimonial Where TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<Testimonial>(query, parameters);
                return values;
            }
        }

        public async Task UpdateTestimonial(Testimonial testimonial)
        {
            string query = "Update Testimonial Set NameSurname=@nameSurname,Title=@title,Comment=@comment,Status=@status where TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@nameSurname", testimonial.NameSurname);
            parameters.Add("@title", testimonial.Title);
            parameters.Add("@comment", testimonial.Comment);
            parameters.Add("@status", testimonial.Status);
            parameters.Add("@testimonialID", testimonial.TestimonialID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}