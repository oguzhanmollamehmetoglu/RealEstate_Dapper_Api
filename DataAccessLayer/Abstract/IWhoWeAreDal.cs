using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IWhoWeAreDal
    {
        Task<List<WhoWeAreDetail>> GetAllWhoWeAreDetail();

        Task CreateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail);

        Task DeleteWhoWeAreDetail(int id);

        Task UpdateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail);

        Task<WhoWeAreDetail> GetWhoWeAreDetail(int id);
    }
}