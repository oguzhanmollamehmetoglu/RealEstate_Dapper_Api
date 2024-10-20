using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataTransferObjectLayer.Dtos.PropertyAmenityDtos;
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

        public async Task CreatePropertyAmenity(CreatePropertyAmenityDto createPropertyAmenityDto)
        {
            string query = "insert into PropertyAmenity(PropertyID,AmenityID,Status) values(@propertyID,@amenityID,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", createPropertyAmenityDto.PropertyID);
            parameters.Add("@amenityID", createPropertyAmenityDto.AmenityID);
            parameters.Add("@status", createPropertyAmenityDto.Status);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<PropertyAmenity>> GetPropertyAmenityByPropertyId(int id)
        {
            string query = "Select PropertyAmenityID,PropertyID,Title,Status From PropertyAmenity Inner Join Amenity On Amenity.AmenityID=PropertyAmenity.AmenityID Where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PropertyAmenity>(query, parameters);
                return values.ToList();
            }
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