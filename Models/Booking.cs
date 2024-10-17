﻿namespace LawnMowingService.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int MachineId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
    }
}
