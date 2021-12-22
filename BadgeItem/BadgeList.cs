using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeItem
{
    class BadgeList
    {
        private Dictionary<int, Badge> _listOfBadges = new Dictionary<int, Badge>();
        private Dictionary<int, Door> _listOfDoors = new Dictionary<int, Door>();
        //Create
        public bool CreateNewBadge(Badge badge)
        {
            bool bReturn = false;
            int badgeCount = _listOfBadges.Count();
            int id = GenerateUniqueId();
            badge.BadgeId = id;

            if (!_listOfBadges.ContainsKey(badge.BadgeId))
            {
                _listOfBadges.Add(badge.BadgeId, badge);
                bReturn = true;
            }
            return bReturn;
        }

        public Badge GetBadgeById(int id)
        {
            return _listOfBadges[id];
        }
        public Dictionary<int, Badge> GetAllBadges()
        {
            return _listOfBadges;
        }

        private int GenerateUniqueId()
        {
            int badgeCount = _listOfBadges.Count;
            return badgeCount + 1;
        }
        private int GenerateUniqueDoor()
        {
            int doorCount = _listOfDoors.Count;
            return doorCount;
        }
    }
}
