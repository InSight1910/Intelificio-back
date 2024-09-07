﻿using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography.X509Certificates;

namespace Intelificio_Back.Models
{
    public class User : IdentityUser<int>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required new string Email { get; set; }
        public required new string PhoneNumber { get; set; }
        public required string Password { get; set; }
        public required string Rut { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Admission { get; set; }
        public required Role Role { get; set; }

        public required IEnumerable<Community> Communities { get; set; }

        public IEnumerable<Attendance> Attendances { get; set; } = Enumerable.Empty<Attendance>();

        public IEnumerable<AssignedShift> AssignedShifts { get; set; } = Enumerable.Empty<AssignedShift>();

        public IEnumerable<Visit> Visits { get; set; } = Enumerable.Empty<Visit>();

        public  IEnumerable<Reservation> Reservations { get; set; } = Enumerable.Empty<Reservation>();


    }
}
