﻿using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Room
    {
        [Key]
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public Section Section { get; set; }

        public Client CurrentClient { get; set; }
        public int CurrentClientId { get; set; }

        public Client PreviousClient { get; set; }
        public int PreviousClientId { get; set; }
    }
    public enum Section
    {
        First,
        Second,
        Third
    }
}
