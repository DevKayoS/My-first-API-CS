namespace MyFirstApi.Entities;

public abstract class Device
{
    protected bool IsConnected() => true;

    public abstract string  GetBrand();

    public void Test()
    {
        var x = IsConnected();
    }

    public virtual string Hello() => "Hello";
}