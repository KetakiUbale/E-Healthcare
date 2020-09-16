
using System;
using System.Collections.Generic;

namespace E_Healthcare.Data
{
  public class Doctor
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string  Mobile { get; set; }
        public string  Specialist { get; set; }
        public string  DaysAvailable { get; set; }
        public DateTime DateTime { get; set; }
        public string RoomName { get; set; }
        public IList<Appointment> Patients { get; set; }


    }
}
