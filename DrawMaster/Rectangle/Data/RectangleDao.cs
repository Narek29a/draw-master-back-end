using DrawMaster.Rectangle.Models;
using Newtonsoft.Json;

namespace DrawMaster.Rectangle.Data;

public class RectangleDao : IRectangleDao
{
    public async Task<RectangleDimension> Get()
    {
        using StreamReader streamReader = new StreamReader(ConfigUtils.GetJsonUrl());
        string json = await streamReader.ReadToEndAsync();
        RectangleDimension? rectangleDimension = JsonConvert.DeserializeObject<RectangleDimension>(json);
        return rectangleDimension ?? throw new InvalidOperationException();
    }

    public async Task<RectangleDimension> Update(RectangleDimension rectangleDimension)
    {
        await using (StreamWriter writer = new StreamWriter(ConfigUtils.GetJsonUrl()))
        {
            string jsonString = JsonConvert.SerializeObject(rectangleDimension);
            await writer.WriteAsync(jsonString);
        }
        return await Get();
    }
}