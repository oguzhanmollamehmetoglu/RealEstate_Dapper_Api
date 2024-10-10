using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class PropertyImageRepository : IPropertyImageDal
    {
        private readonly Context _context;

        public PropertyImageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<PropertyImage>> GetPropertyImageByPropertyId(int id)
        {
            string query = "Select * From PropertyImage Where PropertyID=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PropertyImage>(query, parameters);
                return values.ToList();
            }
        }
    }
}