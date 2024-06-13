using DrawMaster.Rectangle.Models;

namespace DrawMaster.Rectangle.Service;

public interface IRectangleService
{
    
    
    public Task<RectangleDimension> Get();
    
    public Task<RectangleDimension> Update(RectangleDimension rectangleDimension);
    
    
    
}