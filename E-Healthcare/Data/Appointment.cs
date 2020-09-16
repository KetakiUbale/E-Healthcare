
using System;
namespace E_Healthcare.Data
{
    public class Appointment
    {

        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient patient { get; set; }
        public int DoctorId { get; set; }
        public  Doctor Doctor { get; set; }
        public DateTime AppointDate { get; set; }
        public string Diagnosis { get; set; }
        public string  Treatment { get; set; }
        public string  Prescription { get; set; }
        public decimal Amount { get; set; }

        public string Status { get; set; }
    }
}
