using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ISubFeatureDal
    {
        Task<List<SubFeature>> GetAllSubFeature();

        Task CreateSubFeature(SubFeature subFeature);

        Task DeleteSubFeature(int id);

        Task UpdateSubFeature(SubFeature subFeature);

        Task<SubFeature> GetSubFeature(int id);
    }
}