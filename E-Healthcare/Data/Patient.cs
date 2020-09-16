using System;
using System.Collections.Generic;
using System.Text;

namespace E_Healthcare.Data
{
  public class Patient
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public IList<Appointment> Patients { get; set; }
        
       

    }
}
