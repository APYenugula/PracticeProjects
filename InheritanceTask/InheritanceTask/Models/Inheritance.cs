using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

 

namespace InheritanceTask.Model
{
    public class Room_Type
    {
        [Key]
        public string RoomType { get; set; }
        public decimal RoomPrice { get; set; }
        public decimal DefaultRoomPrice { get; set; }
        public BinaryData RoomImg { get; set; }
        public string RoomDesc { get; set; }
    }



    public class Room
    {
        [Key]
        public int RoomNo { get; set; }
        public Room_Type RoomType { get; set; }
        public int HotelCode { get; set; }
        public string Occupancy { get; set; }
    }
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int HotelCode { get; set; }
        public int GuestID { get; set; }
        public int RoomNo { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeOnly BookingTime { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public DateOnly DepartureDate { get; set; }
        public TimeOnly EstArrivalTime { get; set; }
        public TimeOnly EstDepartureTime { get; set; }
        public int NumAdults { get; set; }
        public int NumChildren { get; set; }
        public string SpecialReq { get; set; }

 

    }

 

    

 

    public class Hotel
    {
        [Key]
        public int HotelCode { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int NumRooms { get; set; }
        public int PhoneNo { get; set; }
        public int StarRating { get; set; }
    }

 

    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleTitle { get; set; }
        public string RoleDesc { get; set; }
    }

 

    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public int HotelCode { get; set; }
        public int RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string Gender { get; set; }
        public int PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
    }

 

    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        public int BookingID { get; set; }
        public string GuestTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string Gender { get; set; }
        public int PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PassportNo { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

 

    }

 

    public class Bill
    {
        [Key]
        public int InvoiceNo { get; set; }
        public int BookingID { get; set; }
        public int GuestID { get; set; }
        public decimal RoomCharge { get; set; }
        public string RoomService { get; set;}
        public decimal RestaurantCharges { get; set; }
        public decimal BarCharges { get; set; }
        public decimal MiscCharges { get; set; }
        public Boolean IfLateCheckout { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public int CreditCardNo { get; set; }
        public DateOnly ExpireDate { get; set; }
        public int ChequeNo { get; set; }

 

    }
}