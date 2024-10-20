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

        public async Task AllDeletePropertyImage(int id)
        {
            string query = "Delete From PropertyImage Where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task CreatePropertyImage(PropertyImage propertyImage)
        {
            string query = "insert into PropertyImage(PropertyID,ImageUrl) values(@propertyID,@ımageUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", propertyImage.PropertyID);
            parameters.Add("@ımageUrl", propertyImage.ImageUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeletePropertyImage(int id)
        {
            string query = "Delete From PropertyImage Where PropertyImageId=@propertyImageId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyImageId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<PropertyImage>> GetAllPropertyImageAsync()
        {
            string query = "Select * From PropertyImage";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PropertyImage>(query);
                return values.ToList();
            }
        }

        public async Task<PropertyImage> GetPropertyImage(int id)
        {
            string query = "Select * From PropertyImage Where PropertyImageId=@propertyImageId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyImageId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<PropertyImage>(query, parameters);
                return values;
            }
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

        public async Task UpdatePropertyImage(PropertyImage propertyImage)
        {
            string query = "Update PropertyImage Set ImageUrl=@ımageUrl where PropertyImageId=@propertyImageId";
            var parameters = new DynamicParameters();
            parameters.Add("@ımageUrl", propertyImage.ImageUrl);
            parameters.Add("@propertyImageId", propertyImage.PropertyImageId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}