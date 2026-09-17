using System;
namespace dz1lat.dop
{
    public struct austronaut
    {
        public string name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Favmovie { get; set; }

    }
    public struct TrainTicket
    {
        public string PassengerName { get; set; }
        public string TrainNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public CarriageType Carriage { get; set; }
        public decimal Price { get; set; }
    }

    public struct RentalContract
    {
        public string ClientName { get; set; }
        public string CarModel { get; set; }
        public CarClass VehicleClass { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PricePerDay { get; set; }

    public struct StudentCard
        {
            public string FullName { get; set; }
            public string GradeBookNumber { get; set; } 
            public Faculty StudentFaculty { get; set; }
            public int Course { get; set; }
            public double AverageScore { get; set; }
            public DateTime EnrollmentDate { get; set; }
        }
        public struct User
        {
            public string Name;
            public string City;
            public int Age;
            public string PinCode;
        }
        public struct Drink
        {
            public string Name { get; set; }
            public double AlcoholPercent { get; set; } 

            public Drink(string name, double alcoholPercent)
            {
                Name = name;
                AlcoholPercent = alcoholPercent;
            }
        }

        public struct Student
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public int Id { get; set; }
            public DateTime BirthDate { get; set; }
            public char AlcoholCategory { get; set; } 
            public Drink FavoriteDrink { get; set; }
            public double Volume { get; set; } 
            public double PureAlcoholVolume => Volume * (FavoriteDrink.AlcoholPercent / 100.0);
        }

        internal class latstructs
        {
        }

    }
}
