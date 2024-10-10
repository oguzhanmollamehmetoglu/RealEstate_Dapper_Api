using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBottomGridDal
    {
        Task<List<BottomGrid>> GetAllBottomGrid();

        Task CreateBottomGrid(BottomGrid bottomGrid);

        Task DeleteBottomGrid(int id);

        Task UpdateBottomGrid(BottomGrid bottomGrid);

        Task<BottomGrid> GetBottomGrid(int id);
    }
}