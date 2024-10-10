using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class PropertyDetailRepository : IPropertyDetailDal
    {
        private readonly Context _context;

        public PropertyDetailRepository(Context context)
        {
            _context = context;
        }

        public async Task CreatePropertyDetail(PropertyDetails propertyDetails)
        {
            string query = "insert into PropertyDetails(VideoUrl,Location,BuildYear,PropertyID,GarageSize,RoomCount,BathCount,BedRoomCount,PropertySize,PropertyDetailsStatus) values(@videoUrl,@location,@buildYear,@propertyID,@garageSize,@roomCount,@bathCount,@bedRoomCount,@propertySize,@propertyDetailsStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@propertySize", propertyDetails.PropertySize);
            parameters.Add("@bedRoomCount", propertyDetails.BedRoomCount);
            parameters.Add("@bathCount", propertyDetails.BathCount);
            parameters.Add("@roomCount", propertyDetails.RoomCount);
            parameters.Add("@garageSize", propertyDetails.GarageSize);
            parameters.Add("@buildYear", propertyDetails.BuildYear);
            parameters.Add("@location", propertyDetails.Location);
            parameters.Add("@videoUrl", propertyDetails.VideoUrl);
            parameters.Add("@propertyId", propertyDetails.PropertyID);
            parameters.Add("@propertyDetailsStatus", propertyDetails.PropertyDetailsStatus);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeletePropertyDetail(int id)
        {
            string query = "Delete From PropertyDetails Where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<PropertyDetails>> GetAllPropertyDetail()
        {
            string query = "Select * From PropertyDetails";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PropertyDetails>(query);
                return values.ToList();
            }
        }

        public async Task<PropertyDetails> GetPropertyDetail(int id)
        {
            string query = "Select * From PropertyDetails Where PropertyDetailsID=@propertyDetailsID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyDetailsID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<PropertyDetails>(query, parameters);
                return values;
            }
        }

        public async Task<PropertyDetails> GetPropertyDetailByPropertyId(int id)
        {
            string query = "Select * From PropertyDetails Where PropertyID=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PropertyDetails>(query, parameters);
                return values.FirstOrDefault();
            }
        }

        public async Task UpdatePropertyDetail(PropertyDetails propertyDetails)
        {
            string query = "Update PropertyDetails Set PropertySize=@propertySize,BedRoomCount=@bedRoomCount,BathCount=@bathCount,RoomCount=@roomCount,GarageSize=@garageSize,BuildYear=@buildYear,Location=@location,VideoUrl=@videoUrl,PropertyDetailsStatus=@propertyDetailsStatus where PropertyDetailsID=@propertyDetailsID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertySize", propertyDetails.PropertySize);
            parameters.Add("@bedRoomCount", propertyDetails.BedRoomCount);
            parameters.Add("@bathCount", propertyDetails.BathCount);
            parameters.Add("@roomCount", propertyDetails.RoomCount);
            parameters.Add("@garageSize", propertyDetails.GarageSize);
            parameters.Add("@buildYear", propertyDetails.BuildYear);
            parameters.Add("@location", propertyDetails.Location);
            parameters.Add("@videoUrl", propertyDetails.VideoUrl);
            parameters.Add("@propertyDetailsStatus", propertyDetails.PropertyDetailsStatus);
            parameters.Add("@propertyDetailsID", propertyDetails.PropertyDetailsID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}