Car one = new("GY12 RZB", "Lambourghini");
one.SetMileage();
one.SetInspectionDate();
Console.WriteLine($"Number Plate: {one.GetNumberPlate()}");
Console.WriteLine($"Car Make: {one.GetCarMake()}");
Console.WriteLine($"Mileage: {one.GetMileage()}");
Console.WriteLine($"Inspection Date: {one.GetInspectionDate()}");

class Car
{
    private string numberPlate;
    private string carMake;
    private int mileage;
    private string inspectionDate = string.Empty;

    public Car(string plate, string make)
    {
        carMake = make;
        numberPlate = plate;
    }

    public string GetNumberPlate()
    {
        return numberPlate;
    }

    public string GetCarMake()
    {
        return carMake;
    }

    public int GetMileage()
    {
        return mileage;
    }

    public string GetInspectionDate()
    {
        return inspectionDate;
    }

    public void SetInspectionDate()
    {
        //Declare variable
        DateTime currentDate = DateTime.Now;

        //Return
        inspectionDate = currentDate.ToShortDateString();
    }

    public void SetMileage()
    {
        mileage = 0;
    }
}
