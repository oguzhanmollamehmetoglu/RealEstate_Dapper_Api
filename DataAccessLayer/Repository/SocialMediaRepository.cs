using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class SocialMediaRepository : ISocialMediaDal
    {
        private readonly Context _context;

        public SocialMediaRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateSocialMedia(SocialMedia socialMedia)
        {
            string query = "insert into SocialMedia(Name,Icon,SocialMediaUrl) values(@name,@ıcon,@socialMediaUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", socialMedia.Name);
            parameters.Add("@ıcon", socialMedia.Icon);
            parameters.Add("@socialMediaUrl", socialMedia.SocialMediaUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteSocialMedia(int id)
        {
            string query = "Delete From SocialMedia Where SocialMediaID=@socialMediaID";
            var parameters = new DynamicParameters();
            parameters.Add("@socialMediaID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<SocialMedia>> GetAllSocialMedia()
        {
            string query = "Select * From SocialMedia";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<SocialMedia>(query);
                return values.ToList();
            }
        }

        public async Task<SocialMedia> GetSocialMedia(int id)
        {
            string query = "Select * From SocialMedia Where SocialMediaID=@socialMediaID";
            var parameters = new DynamicParameters();
            parameters.Add("@socialMediaID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<SocialMedia>(query, parameters);
                return values;
            }
        }

        public async Task UpdateSocialMedia(SocialMedia socialMedia)
        {
            string query = "Update SocialMedia Set Name=@name,Icon=@ıcon,SocialMediaUrl=@socialMediaUrl where SocialMediaID=@socialMediaID";
            var parameters = new DynamicParameters();
            parameters.Add("@name", socialMedia.Name);
            parameters.Add("@ıcon", socialMedia.Icon);
            parameters.Add("@socialMediaUrl", socialMedia.SocialMediaUrl);
            parameters.Add("@socialMediaID", socialMedia.SocialMediaID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}