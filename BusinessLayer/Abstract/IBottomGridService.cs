using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBottomGridService
    {
        Task<List<BottomGrid>> TGetAllBottomGrid();

        Task TCreateBottomGrid(BottomGrid bottomGrid);

        Task TDeleteBottomGrid(int id);

        Task TUpdateBottomGrid(BottomGrid bottomGrid);

        Task<BottomGrid> TGetBottomGrid(int id);
    }
}