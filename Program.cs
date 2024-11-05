using System.ComponentModel.DataAnnotations;

Car car = new Car(0);
car.Speed = 100000000;
Car car1 = new Car("Porsche");

Console.WriteLine(car1.Model);
Console.WriteLine(car.Speed);

Console.ReadKey();

class Car
{
    private int speed;
    public String Model { get; set; }
    public Car(String model)
    {
        this.Model = model;
    }

    public Car (int speed)
    {
        Speed = speed;
    }
    public int Speed
    {
        get { return speed; }//read
        set //writable
        {
            if (value > 500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
        }
    }
}