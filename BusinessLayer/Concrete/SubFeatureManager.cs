using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubFeatureManager : ISubFeatureService
    {
        private readonly ISubFeatureDal _subFeatureDal;

        public SubFeatureManager(ISubFeatureDal subFeatureDal)
        {
            _subFeatureDal = subFeatureDal;
        }

        public async Task TCreateSubFeature(SubFeature subFeature)
        {
            await _subFeatureDal.CreateSubFeature(subFeature);
        }

        public async Task TDeleteSubFeature(int id)
        {
            await _subFeatureDal.DeleteSubFeature(id);
        }

        public async Task<List<SubFeature>> TGetAllSubFeature()
        {
            return await _subFeatureDal.GetAllSubFeature();
        }

        public async Task<SubFeature> TGetSubFeature(int id)
        {
            return await _subFeatureDal.GetSubFeature(id);
        }

        public async Task TUpdateSubFeature(SubFeature subFeature)
        {
            await _subFeatureDal.UpdateSubFeature(subFeature);
        }
    }
}