using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public static class FileHandling
    {
        public static void CreateFileFolder()
        {
            if (!Directory.Exists("MovieTicketBooking"))
            {
                Console.WriteLine($"Creating directory");
                Directory.CreateDirectory("MovieTicketBooking");
            }
            if (!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                Console.WriteLine($"Creating user details csv file");
                File.Create("MovieTicketBooking/BookingDetails.csv").Close();

            }
            if (!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                Console.WriteLine($"Creating user details csv file");
                File.Create("MovieTicketBooking/UserDetails.csv").Close();

            }
            if (!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                Console.WriteLine($"Creating movie details csv file");
                File.Create("MovieTicketBooking/MovieDetails.csv").Close();

            }
            if (!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                Console.WriteLine($"Creating screening details csv file");
                File.Create("MovieTicketBooking/ScreeningDetails.csv").Close();

            }
            if (!File.Exists("MovieTicketBooking/TheatreDetails.csv"))
            {
                Console.WriteLine($"Creating theatre details csv file");
                File.Create("MovieTicketBooking/TheatreDetails.csv").Close();

            }
        }
        public static void WriteToCSV()
        {
            string[] users = new string[Operations.userDetailsList.Count];
            for (int i = 0; i < Operations.userDetailsList.Count; i++)
            {
                users[i] = Operations.userDetailsList[i].UserID + "," + Operations.userDetailsList[i].Name + "," + Operations.userDetailsList[i].Age + "," + Operations.userDetailsList[i].PhoneNumber + "," + Operations.userDetailsList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv", users);
            string[] theatres = new string[Operations.theatreDetailsList.Count];
            for (int i = 0; i < Operations.theatreDetailsList.Count; i++)
            {
                theatres[i] = Operations.theatreDetailsList[i].TheatreID + "," + Operations.theatreDetailsList[i].TheatreName + "," + Operations.theatreDetailsList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicketBooking/TheatreDetails.csv", theatres);
            string[] screenings = new string[Operations.screeningDetailsList.Count];
            for (int i = 0; i < Operations.screeningDetailsList.Count; i++)
            {
                screenings[i] = Operations.screeningDetailsList[i].MovieID + "," + Operations.screeningDetailsList[i].TheatreID + "," + Operations.screeningDetailsList[i].NoOfSeats + "," + Operations.screeningDetailsList[i].TicketPrice;
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv", screenings);
            string[] movies = new string[Operations.movieDetailsList.Count];
            for (int i = 0; i < Operations.movieDetailsList.Count; i++)
            {
                movies[i] = Operations.movieDetailsList[i].MovieID + "," + Operations.movieDetailsList[i].MovieName + "," + Operations.movieDetailsList[i].Language;
            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv", movies);
            string[] bookings = new string[Operations.bookingDetailsList.Count];
            for (int i = 0; i < Operations.bookingDetailsList.Count; i++)
            {
                bookings[i] = Operations.bookingDetailsList[i].BookingID + "," + Operations.bookingDetailsList[i].UserID + "," + Operations.bookingDetailsList[i].MovieID + "," + Operations.bookingDetailsList[i].TheatreID + "," + Operations.bookingDetailsList[i].SeatCount + "," + Operations.bookingDetailsList[i].TotalAmount + "," + Operations.bookingDetailsList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv", bookings);
        }
        public static void ReadFromCSV()
        {
            string[] users = File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            for (int i = users.Length - 1; i >= 0; i--)
            {
                UserDetails user1 = new UserDetails(users[i]);
                Operations.userDetailsList.Add(user1);
            }
            string[] theatres = File.ReadAllLines("MovieTicketBooking/TheatreDetails.csv");
            for (int i = theatres.Length - 1; i >= 0; i--)
            {
                TheatreDetails theatre1 = new TheatreDetails(theatres[i]);
                Operations.theatreDetailsList.Add(theatre1);
            }
            string[] screenings = File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            for (int i = screenings.Length - 1; i >= 0; i--)
            {

                ScreeningDetails screening1 = new ScreeningDetails(screenings[i]);
                Operations.screeningDetailsList.Add(screening1);
            }
            string[] movies = File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            for (int i = movies.Length - 1; i >= 0; i--)
            {

                MovieDetails movie1 = new MovieDetails(movies[i]);
                Operations.movieDetailsList.Add(movie1);
            }
            string[] bookings = File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            for (int i = bookings.Length - 1; i >= 0; i--)
            {
                BookingDetails booking1 = new BookingDetails(bookings[i]);
                Operations.bookingDetailsList.Add(booking1);
            }

        }
    }
}