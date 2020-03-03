using System;

namespace GymTesting
{
    public class clsSession
    {
  
        public int SessionID { get; set; }
        public string Type { get; set; }
        public DateTime datetime { get; set; }
        public bool EquipmentRequired { get; set; }
        public int TrainerID { get; set; }
        public int BranchID { get; set; }
        public double Cost { get; set; }

        public bool Find(int testSessionID)
        {
            // always return true
            return true;
        }
    }
}