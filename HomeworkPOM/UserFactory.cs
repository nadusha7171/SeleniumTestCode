using AutoFixture;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM
{
      class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            var fixture = new Fixture();
            var dateTime = fixture.Create<DateTime>();

            return new RegistrationUser
            {
                FirstName = "Lala",
                LastName = "Dimitrova",
                Password = "1234567",
                Address = "1st Avenue",
                City = "Delano",
                State = "Minnesota",
                Country = "United States",
                Phone = "5552222522",
                PostCode = "55329",
                Alias = string.Empty
            };
        }
    }
}
