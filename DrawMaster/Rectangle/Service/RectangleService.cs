using DrawMaster.Rectangle.Data;
using DrawMaster.Rectangle.Models;

namespace DrawMaster.Rectangle.Service;

public class RectangleService : IRectangleService
{
    
    private readonly IRectangleDao _rectangleDao;

    public RectangleService(IRectangleDao rectangleDao)
    {
        _rectangleDao = rectangleDao;
    }
    
    public Task<RectangleDimension> Get()
    {
        return _rectangleDao.Get();
    }

    public Task<RectangleDimension> Update(RectangleDimension rectangleDimension)
    {
        return _rectangleDao.Update(rectangleDimension);
    }

}