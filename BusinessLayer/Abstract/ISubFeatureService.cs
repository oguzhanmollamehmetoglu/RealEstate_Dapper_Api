using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ISubFeatureService
    {
        Task<List<SubFeature>> TGetAllSubFeature();

        Task TCreateSubFeature(SubFeature subFeature);

        Task TDeleteSubFeature(int id);

        Task TUpdateSubFeature(SubFeature subFeature);

        Task<SubFeature> TGetSubFeature(int id);
    }
}