using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IServiceService
    {
        Task<List<Service>> TGetAllService();

        Task TCreateService(Service service);

        Task TDeleteService(int id);

        Task TUpdateService(Service service);

        Task<Service> TGetService(int id);
    }
}