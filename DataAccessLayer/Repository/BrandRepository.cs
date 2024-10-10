using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class BrandRepository : IBrandDal
    {
        private readonly Context _context;

        public BrandRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateBrand(Brand brand)
        {
            string query = "insert into Brand(BrandImageUrl,BrandImageLink) values(@brandImageUrl,@brandImageLink)";
            var parameters = new DynamicParameters();
            parameters.Add("@brandImageUrl", brand.BrandImageUrl);
            parameters.Add("@brandImageLink", brand.BrandImageLink);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteBrand(int id)
        {
            string query = "Delete From Brand Where BrandID=@brandID";
            var parameters = new DynamicParameters();
            parameters.Add("@brandID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<Brand>> GetAllBrand()
        {
            string query = "Select * From Brand";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Brand>(query);
                return values.ToList();
            }
        }

        public async Task<Brand> GetBrand(int id)
        {
            string query = "Select * From Brand Where BrandID=@brandID";
            var parameters = new DynamicParameters();
            parameters.Add("@brandID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<Brand>(query, parameters);
                return values;
            }
        }

        public async Task UpdateBrand(Brand brand)
        {
            string query = "Update Brand Set BrandImageUrl=@brandImageUrl,BrandImageLink=@brandImageLink where BrandID=@brandID";
            var parameters = new DynamicParameters();
            parameters.Add("@brandImageUrl", brand.BrandImageUrl);
            parameters.Add("@brandImageLink", brand.BrandImageLink);
            parameters.Add("@brandID", brand.BrandID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}