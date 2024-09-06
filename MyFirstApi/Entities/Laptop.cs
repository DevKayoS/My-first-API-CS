namespace MyFirstApi.Entities;

public sealed class Laptop : Device
{
    public string GetModel()
    {
        var isConnected = IsConnected();
        if (isConnected)
            return "Macbook";

        return "Unknow";
    }

    public override string Hello() => "Hello laptop";

    public override string GetBrand() => "Apple";
}