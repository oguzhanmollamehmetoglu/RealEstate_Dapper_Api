using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IWhoWeAreService
    {
        Task<List<WhoWeAreDetail>> TGetAllWhoWeAreDetail();

        Task TCreateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail);

        Task TDeleteWhoWeAreDetail(int id);

        Task TUpdateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail);

        Task<WhoWeAreDetail> TGetWhoWeAreDetail(int id);
    }
}