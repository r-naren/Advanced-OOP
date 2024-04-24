using System;
namespace ParentDetail;
class Program{
    public static void Main(string[] args)
    {
        PatientInfo patient = new PatientInfo("Naren", "Ramasamy",34,"Tiruppur", "Accident");
        patient.DisplayInfo();
        DoctorInfo doctor = new DoctorInfo("Chopper", "Kumarasamy");
        patient.DisplayInfo();
    }
}