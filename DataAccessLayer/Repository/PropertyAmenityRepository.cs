using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class PropertyAmenityRepository : IPropertyAmenityDal
    {
        private readonly Context _context;

        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<PropertyAmenity>> GetPropertyAmenityByStatusTrue(int id)
        {
            string query = "Select PropertyAmenityID,PropertyID,Title,Status From PropertyAmenity Inner Join Amenity On Amenity.AmenityID=PropertyAmenity.AmenityID Where PropertyID=@propertyID And Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PropertyAmenity>(query, parameters);
                return values.ToList();
            }
        }
    }
}