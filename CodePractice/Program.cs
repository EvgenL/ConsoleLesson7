// using CodePractice;
//
// var carInstance = new Car(4, "Audi");
// carInstance.PrintCarInfo();
//
// var anotherCar = new Car(6, "KAMAZ");
// anotherCar.PrintCarInfo();
//
// Console.WriteLine(CarRepairBase.PriceForRepair);
//
// var baseInstance = new CarRepairBase();
//
// CarRepairBase.PriceForRepair = 400;



var tester = new EventTester();
var sub = new Subscriber();

// порядок важен!
tester.OnEventHappened += sub.Delete;

tester.OnEventHappened += sub.Print;
// tester.OnEventHappened += delegate { sub.Print(5); };
// tester.OnEventHappened += () => sub.Print(5);

tester.CallEvent();


// var array = new int[10];
//
// for (int i = 0; i < 99; i++)
// {
//     Console.WriteLine(array[i]);
// }
//
// foreach (int currentInt in array)
// {
//     Console.WriteLine(currentInt);
// }



public class Subscriber
{
    public void Print()
    {
        Console.WriteLine("Subscriber recieved event!");
    }
    public void Delete()
    {
        Console.WriteLine("Subscriber Delete!");
    }
}


public class EventTester
{
    public event Action OnEventHappened;

    public void CallEvent()
    {
        // То же самое, что и OnEventHappened?.Invoke();
        // if (OnEventHappened != null)
        // {
        //     OnEventHappened.Invoke();
        // }
        
        
        OnEventHappened?.Invoke();
    }
}