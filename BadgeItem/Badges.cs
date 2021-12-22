using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeItem
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public string Door { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameForBadge => $"{FirstName} {LastName}";

        public Badge(int badgeID, string door, string firstName, string lastName)
        {
            BadgeId = badgeID;
            Door = door;
            FirstName = firstName;
            LastName = lastName;
        }      
    }
    public class Door
    {
        public string DoorLetter { get; set; }
        public int DoorNumber { get; set; }
        public string DoorName => $"{DoorLetter} {DoorNumber}";

        public Door(string doorLetter, int doorNumber)
        {
            DoorLetter = doorLetter;
            DoorNumber = doorNumber;
        }
    }
}
