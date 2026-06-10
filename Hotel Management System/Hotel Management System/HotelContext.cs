using Hotel_Management_System.Models;

namespace Hotel_Management_System
{
    public class HotelContext
    {
        public List<RoomModel> rooms { get; set; }
        public List<GuestModel> guests { get; set; }
        public List<BookingModel> bookings { get; set; } 
        public List<ReviewModel> reviews { get; set; } 
        public List<StaffModel> staff { get; set; } 


        
      }
    }


