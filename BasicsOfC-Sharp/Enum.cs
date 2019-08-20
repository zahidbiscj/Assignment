using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    class Enum
    {
        public static void main(String[] args) {
            var user = new User();

            if (user.status == RegistrationStatus.Active && user.userType == UserType.Admin) {
                Console.WriteLine("Login Successfully");
            }
        }

    }

    public class User {
        public string Name { get; set; }
        public RegistrationStatus status { get; set; }
        public UserType userType { get; set; }
    }

    public enum RegistrationStatus {
        Inactive,
        Blocked,
        Active
    }

   public enum UserType {
        Member,
        Support,
        Admin
    }

    enum WeekDays {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
}
