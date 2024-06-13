using DrawMaster.Rectangle.Models;

namespace DrawMaster.Rectangle.Data;

public interface IRectangleDao
{
    public Task<RectangleDimension> Get();
    
    public Task<RectangleDimension> Update(RectangleDimension rectangleDimension);


}