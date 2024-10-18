using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataTransferObjectLayer.Dtos.PropertyDtos;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class PropertyRepository : IPropertyDal
    {
        private readonly Context _context;

        public PropertyRepository(Context context)
        {
            _context = context;
        }

        public async Task AdvertPropertyStatusChangeToFalse(int id)
        {
            string query = "Update Property Set AdvertPropertyStatus=0,PropertyStatus=0 where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task CreateProperty(Property property)
        {
            string query = "insert into Property(Title,SlugUrl,Price,City,District,Coverİmage,Address,Description,Type,DealOfTheDay,AdvertisementDate,PropertyStatus,PropertyCategory,AppUserID) values(@title,@slugUrl,@price,@city,@district,@coverİmage,@address,@description,@type,@dealOfTheDay,@advertisementDate,@propertyStatus,@propertyCategory,@appUserID)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", property.Title);
            parameters.Add("@slugUrl", property.SlugUrl);
            parameters.Add("@price", property.Price);
            parameters.Add("@city", property.City);
            parameters.Add("@district", property.District);
            parameters.Add("@coverİmage", property.Coverİmage);
            parameters.Add("@address", property.Address);
            parameters.Add("@description", property.Description);
            parameters.Add("@type", property.Type);
            parameters.Add("@dealOfTheDay", property.DealOfTheDay);
            parameters.Add("@advertisementDate", property.AdvertisementDate);
            parameters.Add("@propertyStatus", property.PropertyStatus);
            parameters.Add("@propertyCategory", property.PropertyCategory);
            parameters.Add("@appUserID", property.AppUserID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteProperty(int id)
        {
            string query = "Delete From Property Where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<Property>> GetAllPropertyAsync()
        {
            string query = "Select * From Property";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLastFivePropertyWithCategoryDto>> GetLastFivePropertyAsync()
        {
            string query = "Select Top(5) PropertyID,Title,SlugUrl,Price,City,District,PropertyCategory,CategoryName,AdvertisementDate From Property Inner Join Category On Property.PropertyCategory=Category.CategoryID Where Type='Kiralık' and PropertyStatus=1 Order By PropertyID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLastFivePropertyWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<Property>> GetLastThreePropertyAsync()
        {
            string query = "Select Top(3) PropertyID,Title,SlugUrl,Price,City,District,PropertyCategory,CategoryName,AdvertisementDate,Coverİmage,Description From Property Inner Join Category On Property.PropertyCategory=Category.CategoryID Order By PropertyID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query);
                return values.ToList();
            }
        }

        public async Task<Property> GetProperty(int id)
        {
            string query = "Select * From Property Where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<Property>(query, parameters);
                return values;
            }
        }

        public async Task<List<Property>> GetPropertyAdvertListByAppUserAsyncByFalse(int id)
        {
            string query = "Select PropertyID,Title,SlugUrl,Price,City,District,Type,Coverİmage,Address,CategoryName,DealOfTheDay From Property inner join Category on Property.PropertyCategory=Category.CategoryID Where AppUserID=@appUserID and PropertyStatus=0 and AdvertPropertyStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<Property>> GetPropertyAdvertListByAppUserAsyncByTrue(int id)
        {
            string query = "Select PropertyID,Title,SlugUrl,Price,City,District,Type,Coverİmage,Address,CategoryName,DealOfTheDay From Property inner join Category on Property.PropertyCategory=Category.CategoryID Where AppUserID=@appUserID and PropertyStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<Property>> GetPropertyAdvertListByAppUserAsyncByStatusFalse(int id)
        {
            string query = "Select PropertyID,Title,SlugUrl,Price,City,District,Type,Coverİmage,Address,CategoryName,DealOfTheDay From Property inner join Category on Property.PropertyCategory=Category.CategoryID Where AppUserID=@appUserID and PropertyStatus=0 and AdvertPropertyStatus=0";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<Property>> GetPropertyByDealOfTheDayTrueWithCategoryAsync()
        {
            string query = "Select PropertyID,Title,Price,City,District,Type,Coverİmage,Address,CategoryName,DealOfTheDay,SlugUrl From Property inner join Category on Property.PropertyCategory=Category.CategoryID where DealOfTheDay=1 ";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query);
                return values.ToList();
            }
        }

        public async Task<Property> GetPropertyByPropertyId(int id)
        {
            string query = "Select PropertyID,Title,Price,City,District,Type,Coverİmage,Address,CategoryName,AppUserID,DealOfTheDay,AdvertisementDate,Description,SlugUrl From Property inner join Category on Property.PropertyCategory=Category.CategoryID where PropertyID=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query, parameters);
                return values.FirstOrDefault();
            }
        }

        public async Task<List<Property>> GetPropertyWithSearchListAsync(string searchKeyValue, int propertyCategoryId, string city)
        {
            string query = "Select * From Property Where Title like '%" + searchKeyValue + "%' And PropertyCategory=@propertyCategoryId And City=@city";
            var parameters = new DynamicParameters();
            //parameters.Add("@searchKeyValue", searchKeyValue);
            parameters.Add("@propertyCategoryId", propertyCategoryId);
            parameters.Add("@city", city);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<Property>> GetResultPropertyWithCategoryAsync()
        {
            string query = "SELECT p.PropertyID, p.Title, p.Price, p.City, p.District, p.Type, p.Coverİmage, p.Address, c.CategoryName, p.DealOfTheDay, p.SlugUrl, p.PropertyStatus FROM Property p INNER JOIN Category c ON p.PropertyCategory = c.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query);
                return values.ToList();
            }
        }

        public async Task<List<Property>> GetResultPropertyWithCategoryStatusByTrueAsync()
        {
            string query = "SELECT p.PropertyID, p.Title, p.Price, p.City, p.District, p.Type, p.Coverİmage, p.Address, c.CategoryName, p.AppUserID, p.DealOfTheDay, p.SlugUrl, p.PropertyStatus FROM Property p INNER JOIN Category c ON p.PropertyCategory = c.CategoryID Where PropertyStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Property>(query);
                return values.ToList();
            }
        }

        public async Task PropertyDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Property Set DealOfTheDay=0 where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task PropertyDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Property Set DealOfTheDay=1 where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task PropertyStatusChangeToFalse(int id)
        {
            string query = "Update Property Set PropertyStatus=0 where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task PropertyStatusChangeToTrue(int id)
        {
            string query = "Update Property Set PropertyStatus=1 where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task UpdateProperty(UpdatePropertyDtos updatePropertyDtos)
        {
            string query = "Update Property Set Title=@title,SlugUrl=@slugUrl,Price=@price,City=@city,District=@district,Coverİmage=@coverİmage,Address=@address,Description=@description,Type=@type,DealOfTheDay=@dealOfTheDay,AdvertisementDate=@advertisementDate,PropertyStatus=@propertyStatus,AdvertPropertyStatus=@advertPropertyStatus,PropertyCategory=@propertyCategory,AppUserID=@appUserID where PropertyID=@propertyID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updatePropertyDtos.Title);
            parameters.Add("@slugUrl", updatePropertyDtos.SlugUrl);
            parameters.Add("@price", updatePropertyDtos.Price);
            parameters.Add("@city", updatePropertyDtos.City);
            parameters.Add("@district", updatePropertyDtos.District);
            parameters.Add("@coverİmage", updatePropertyDtos.Coverİmage);
            parameters.Add("@address", updatePropertyDtos.Address);
            parameters.Add("@description", updatePropertyDtos.Description);
            parameters.Add("@type", updatePropertyDtos.Type);
            parameters.Add("@dealOfTheDay", updatePropertyDtos.DealOfTheDay);
            parameters.Add("@advertisementDate", updatePropertyDtos.AdvertisementDate);
            parameters.Add("@propertyStatus", updatePropertyDtos.PropertyStatus);
            parameters.Add("@advertPropertyStatus", updatePropertyDtos.AdvertPropertyStatus);
            parameters.Add("@propertyCategory", updatePropertyDtos.PropertyCategory);
            parameters.Add("@appUserID", updatePropertyDtos.AppUserID);
            parameters.Add("@propertyID", updatePropertyDtos.PropertyID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}