using System;

namespace GymClasses
{
    public class clsTrainer
    {
        public int TrainerID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Retrained { get; set; }
    }
}