using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public async Task TCreateService(Service service)
        {
            await _serviceDal.UpdateService(service);
        }

        public async Task TDeleteService(int id)
        {
            await _serviceDal.DeleteService(id);
        }

        public async Task<List<Service>> TGetAllService()
        {
            return await _serviceDal.GetAllService();
        }

        public async Task<Service> TGetService(int id)
        {
            return await _serviceDal.GetService(id);
        }

        public async Task TUpdateService(Service service)
        {
            await _serviceDal.UpdateService(service);
        }
    }
}