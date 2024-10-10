using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IServiceDal
    {
        Task<List<Service>> GetAllService();

        Task CreateService(Service service);

        Task DeleteService(int id);

        Task UpdateService(Service service);

        Task<Service> GetService(int id);
    }
}