using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BottomGridManager : IBottomGridService
    {
        private readonly IBottomGridDal _bottomGridDal;

        public BottomGridManager(IBottomGridDal bottomGridDal)
        {
            _bottomGridDal = bottomGridDal;
        }

        public async Task TCreateBottomGrid(BottomGrid bottomGrid)
        {
            await _bottomGridDal.CreateBottomGrid(bottomGrid);
        }

        public async Task TDeleteBottomGrid(int id)
        {
            await _bottomGridDal.DeleteBottomGrid(id);
        }

        public async Task<List<BottomGrid>> TGetAllBottomGrid()
        {
            return await _bottomGridDal.GetAllBottomGrid();
        }

        public async Task<BottomGrid> TGetBottomGrid(int id)
        {
            return await _bottomGridDal.GetBottomGrid(id);
        }

        public async Task TUpdateBottomGrid(BottomGrid bottomGrid)
        {
            await _bottomGridDal.UpdateBottomGrid(bottomGrid);
        }
    }
}