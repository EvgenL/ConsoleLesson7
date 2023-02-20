namespace CodePractice;

public class Car
{
    private int _wheelsCount;
    private string _carBrand;
    
    public Car(int wheelsCount, string carBrand)
    {
        _wheelsCount = wheelsCount;
        _carBrand = carBrand;
    }

    public void PrintCarInfo()
    {
        Console.WriteLine($"Car. Wheels: {_wheelsCount}, Brand: {_carBrand}");
        // Console.WriteLine("Car. Wheels: " + _wheelsCount + ", Brand: " + _carBrand);
    }
}