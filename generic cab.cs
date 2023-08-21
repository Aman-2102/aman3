using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{ }
public class FieldId<T, V>
{
    public T id { get; set; }
    public V CreatedOn { get; set; }

}
public class userdetail : FieldId<int, DateTime>
{
    public string UserName { get; set; }
    public string Gender { get; set; }
    public int WalletAmount { get; set; }
}
public class DriverDetail : FieldId<int, DateTime>

{
    public string GEnder { get; set; }
    public string drivername { get; set; }
}

public class DriverLocation : FieldId<int, DateTime>
{
    public int LocationId { get; set; }
    public string Avalibility { get; set; }
   
}

public class userdrive : FieldId<int, DateTime>
{
    public int UserId { get; set; }
    public int PickupLocationId { get; set; }
    public int dropLocationId { get; set; }
   
}

public class locationMapping : FieldId<int, DateTime>
{
    public int LocationId { get; set; }
    public string LocationName{ get; set; }
}

public class booking : FieldId<int, DateTime>
{
    public int UserId { get; set; }
    public int Driverid { get; set; }

    public int charge { get; set; }
}



class Program
{
    static void Main(string[] args)
    {
        userdetail Userobj = new userdetail();
        Userobj.id = 1;
        Userobj.UserName = "Aman";
        Userobj.Gender = "male";
        Userobj.WalletAmount=1200;
        Userobj.CreatedOn = DateTime.Now;

       DriverDetail Driverobj = new DriverDetail();
        Driverobj.id = 201;
        Driverobj.GEnder = "male";
        Driverobj.drivername = "mahesh";


        userdrive userdriveobj = new userdrive()
        {
            id = 1,
            PickupLocationId = 501,
            dropLocationId = 502
           
        };

    DriverLocation Dlocationobj = new DriverLocation()
    {
        id = 201,

        LocationId = 501,
        Avalibility="yes"

        };

    locationMapping locationobj = new locationMapping()
    {

        LocationId = 501,
        LocationName="kalupur"
        

        };

        booking bookingobj = new booking()
        {
            id = 1001,
            UserId = Userobj.id,
            Driverid=Driverobj.id,
           charge=300,
            CreatedOn = DateTime.Now
        };

       


        Console.WriteLine("User Id: " + Userobj.id + " " + "  Name Of User-" + Userobj.UserName + " "+"WALLET Amount:" +Userobj.WalletAmount);
        Console.WriteLine("driver detail Name is: " +Driverobj.drivername);
        Console.WriteLine(" userdrive:  PickupLocation:" + userdriveobj.PickupLocationId + " " +"DropLocation:"+ userdriveobj.dropLocationId);
        Console.WriteLine("driverlocation: Avalibility :" + Dlocationobj.Avalibility + " Locationid " + Dlocationobj.LocationId);
        Console.WriteLine("location: " + locationobj.LocationId + " " +"Location Name"+ locationobj.LocationName);
        Console.WriteLine("booking: " +"Userid"+ bookingobj.UserId + " " +"Driverid"+ Driverobj.id + " " +"Charge :"+ bookingobj.charge);
       
        Console.ReadKey();
    }
}
