using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public int StaffID { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public DateTime StaffDateofBirth { get; set; }
        public string StaffNumber { get; set; }
        public int StaffAddress { get; set; }
        public string StaffEmail { get; set; }
    }
}