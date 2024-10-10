using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class WhoWeAreManager : IWhoWeAreService
    {
        private readonly IWhoWeAreDal _whoWeAreDal;

        public WhoWeAreManager(IWhoWeAreDal whoWeAreDal)
        {
            _whoWeAreDal = whoWeAreDal;
        }

        public async Task TCreateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail)
        {
            await _whoWeAreDal.CreateWhoWeAreDetail(whoWeAreDetail);
        }

        public async Task TDeleteWhoWeAreDetail(int id)
        {
            await _whoWeAreDal.DeleteWhoWeAreDetail(id);
        }

        public async Task<List<WhoWeAreDetail>> TGetAllWhoWeAreDetail()
        {
            return await _whoWeAreDal.GetAllWhoWeAreDetail();
        }

        public async Task<WhoWeAreDetail> TGetWhoWeAreDetail(int id)
        {
            return await _whoWeAreDal.GetWhoWeAreDetail(id);
        }

        public async Task TUpdateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail)
        {
            await _whoWeAreDal.UpdateWhoWeAreDetail(whoWeAreDetail);
        }
    }
}