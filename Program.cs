// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 1; j <= i; j++)
//     {
//         Console.Write("*");
//     }
//    Console.WriteLine();
// }


// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 1; j <= 5; j++)
//     {
//         if (i == 1 || i == 5 || j == 1 || j == 5)
//         {
//             Console.Write("*");
//         }
//         else
//         {
//             Console.Write(" ");
//         }
//     }

//     Console.WriteLine();
// }
// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 1; j <= i; j++)
//     {
//         if (j == 1 || j == i || i == 5)
//         {
//             Console.Write("*");
//         }
//         else
//         {
  
//         }
//     }

//     Console.WriteLine();
// }
// int n = 5;

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 1; k <= 2 * i - 1; k++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// int n = 5;

// // Top half
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 1; k <= 2 * i - 1; k++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// // Bottom half
// for (int i = n - 1; i >= 1; i--)
// {
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 1; k <= 2 * i - 1; k++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();

// }


// int n = 5;

// // Top half
// for (int i = n; i >= 1; i--)
// {
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 1; k <= 2 * i - 1; k++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// // Bottom half
// for (int i = 2; i <= n; i++)
// {
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write(" ");
//     }

//     for (int k = 1; k <= 2 * i - 1; k++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// Array   //


// using System;

// class Program
// {
//     static void Main()
//     {
//         string[] student = {
//             "Dhurba Bohara",
//             "bj19ig",
//             "BSc IT",
//             "ISMT College",
//             "dhurba3131@example.com",
//             "9766709024"
//         };

//         Console.WriteLine("         STUDENT ID CARD        ");
//         Console.WriteLine("Student Name : " + student[0]);
//         Console.WriteLine("Student ID   : " + student[1]);
//         Console.WriteLine("Course       : " + student[2]);
//         Console.WriteLine("College      : " + student[3]);
//         Console.WriteLine("Email        : " + student[4]);
//         Console.WriteLine("Phone        : " + student[5]);
//     }
// }


// using System;

// class Film
// {
//     public string Title;
//     public string Genre;
//     public int Duration;
     
//     // Default constructor
//     public Film()
//     {
//         Title = "Unknown";
//         Genre = "Unknown";
//         Duration = 0;
//     }

//     // Parameterized constructor
//     public Film(string title, string genre, int duration)
//     {
//         Title = title;
//         Genre = genre;
//         Duration = duration;
//     }

//     public void DisplayInfo()
//     {
//         Console.WriteLine("Film Title: " + Title);
//         Console.WriteLine("Genre: " + Genre);
//         Console.WriteLine("Duration: " + Duration + " minutes");
//         Console.WriteLine();
//     }
// }

// class Program
// {    
//     static void Main()
//     {
//         Film film1 = new Film();

//         Film film2 = new Film("Avengers", "Action", 180);

//         Console.WriteLine("Film 1:");
//         film1.DisplayInfo();

//         Console.WriteLine("Film 2:");
//         film2.DisplayInfo();
//     }
// }



// using System;

// class Movie
// {
//     public string MovieName;
//     public int Duration;
//     public string Genre;
//     public bool IsAvailable;

//     public Movie(string movieName, int duration, string genre, bool isAvailable)
//     {
//         MovieName = movieName;
//         Duration = duration;
//         Genre = genre;
//         IsAvailable = isAvailable;
//     }

//     public void DisplayMovie()
//     {
//         Console.WriteLine("Movie Name: " + MovieName);
//         Console.WriteLine("Duration: " + Duration + " minutes");
//         Console.WriteLine("Genre: " + Genre);
//         Console.WriteLine("Available: " + (IsAvailable ? "Yes" : "No"));
//         Console.WriteLine("-------------------------");
//     }
// }

// class Customer
// {
//     public int CustomerID;
//     public string CustomerName;
//     public int Age;
//     public string PhoneNumber;
//     public string SelectedMovie;

//     public Customer(int customerID, string customerName,
//                     int age, string phoneNumber, string selectedMovie)
//     {
//         CustomerID = customerID;
//         CustomerName = customerName;
//         Age = age;
//         PhoneNumber = phoneNumber;
//         SelectedMovie = selectedMovie;
//     }

//     public void DisplayCustomer()
//     {
//         Console.WriteLine("\n===== CUSTOMER DETAILS =====");
//         Console.WriteLine("Customer ID: " + CustomerID);
//         Console.WriteLine("Customer Name: " + CustomerName);
//         Console.WriteLine("Age: " + Age);
//         Console.WriteLine("Phone Number: " + PhoneNumber);
//         Console.WriteLine("Selected Movie: " + SelectedMovie);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Movie[] movies =
//         {
//             new Movie("Avengers", 180, "Action", true),
//             new Movie("Titanic", 195, "Romance", true),
//             new Movie("Conjuring", 112, "Horror", false),
//             new Movie("Interstellar", 169, "Sci-Fi", true),
//             new Movie("Joker", 122, "Drama", true)
//         };

//         Console.WriteLine("===== WELCOME TO CINEMA =====\n");
//         Console.WriteLine("===== AVAILABLE MOVIES =====");

//         foreach (Movie movie in movies)
//         {
//             movie.DisplayMovie();
//         }

//         // Get customer details from user
//         Console.Write("\nEnter Customer ID: ");
//         int id = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter Customer Name: ");
//         string name = Console.ReadLine() ?? "";

//         Console.Write("Enter Age: ");
//         int age = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter Phone Number: ");
//         string phone = Console.ReadLine() ?? "";

//         Console.WriteLine("\nEnter the movie number you want to watch:");

//         for (int i = 0; i < movies.Length; i++)
//         {
//             Console.WriteLine((i + 1) + ". " + movies[i].MovieName
//                 + (movies[i].IsAvailable ? " (Available)" : " (Unavailable)"));
//         }

//         Console.Write("Choose movie number: ");
//         int choice = Convert.ToInt32(Console.ReadLine());

//         if (choice >= 1 && choice <= movies.Length
//             && movies[choice - 1].IsAvailable)
//         {
//             Customer customer = new Customer(
//                 id,
//                 name,
//                 age,
//                 phone,
//                 movies[choice - 1].MovieName
//             );

//             customer.DisplayCustomer();
//             Console.WriteLine("\nMovie selection successful!");
//         }
//         else
//         {
//             Console.WriteLine("\nInvalid choice or movie unavailable.");
//         }

//         Console.WriteLine("\nPress Enter to exit.");
//         Console.ReadLine();
//     }
// }


// using System;

// class Movie
// {
//     public string MovieName;
//     public int Duration;
//     public string Genre;
//     public decimal Price;
//     public string HallName;
//     public bool IsAvailable;

//     public Movie(string movieName, int duration, string genre,
//                  decimal price, string hallName, bool isAvailable)
//     {
//         MovieName = movieName;
//         Duration = duration;
//         Genre = genre;
//         Price = price;
//         HallName = hallName;
//         IsAvailable = isAvailable;
//     }

//     public void DisplayMovie(int number)
//     {
//         Console.WriteLine(number + ". " + MovieName);
//         Console.WriteLine("   Duration: " + Duration + " minutes");
//         Console.WriteLine("   Genre: " + Genre);
//         Console.WriteLine("   Ticket Price: Rs. " + Price);
//         Console.WriteLine("   Status: " +
//             (IsAvailable ? "Available" : "Unavailable"));
//         Console.WriteLine();
//     }
// }

// class Customer
// {
//     public int CustomerID;
//     public string CustomerName;
//     public int Age;
//     public string PhoneNumber;
//     public string SelectedMovie;
//     public string SelectedHall;
//     public decimal TicketPrice;

//     public Customer(int id, string name, int age, string phone,
//                     string movie, string hall, decimal price)
//     {
//         CustomerID = id;
//         CustomerName = name;
//         Age = age;
//         PhoneNumber = phone;
//         SelectedMovie = movie;
//         SelectedHall = hall;
//         TicketPrice = price;
//     }

//     public void DisplayCustomer()
//     {
//         Console.WriteLine("\n========== BOOKING RECEIPT ==========");
//         Console.WriteLine("Customer ID: " + CustomerID);
//         Console.WriteLine("Customer Name: " + CustomerName);
//         Console.WriteLine("Age: " + Age);
//         Console.WriteLine("Phone Number: " + PhoneNumber);
//         Console.WriteLine("Cinema Hall: " + SelectedHall);
//         Console.WriteLine("Movie: " + SelectedMovie);
//         Console.WriteLine("Ticket Price: Rs. " + TicketPrice);
//         Console.WriteLine("=====================================");
//         Console.WriteLine("       BOOKING SUCCESSFUL!");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string[] halls =
//         {
//             "Dwarika",
//             "INI",
//             "QBox",
//             "Friends Cinema"
//         };

//         Movie[] movies =
//         {
//             new Movie("Avengers", 180, "Action", 350, "Dwarika", true),
//             new Movie("Titanic", 195, "Romance", 300, "Dwarika", true),
//             new Movie("Joker", 122, "Drama", 280, "INI", true),
//             new Movie("Interstellar", 169, "Sci-Fi", 400, "INI", true),
//             new Movie("Conjuring", 112, "Horror", 250, "QBox", true),
//             new Movie("Spider-Man", 140, "Action", 350, "QBox", true),
//             new Movie("Frozen", 102, "Animation", 250, "Friends Cinema", true),
//             new Movie("The Batman", 176, "Action", 320, "Friends Cinema", true)
//         };

//         Console.WriteLine("=====================================");
//         Console.WriteLine("       BUTWAL CINEMA BOOKING");
//         Console.WriteLine("=====================================");

//         Console.WriteLine("\nSelect your cinema hall:\n");

//         for (int i = 0; i < halls.Length; i++)
//         {
//             Console.WriteLine((i + 1) + ". " + halls[i]);
//         }

//         Console.Write("\nEnter hall number: ");

//         if (!int.TryParse(Console.ReadLine(), out int hallChoice) ||
//             hallChoice < 1 || hallChoice > halls.Length)
//         {
//             Console.WriteLine("Invalid hall selection.");
//             return;
//         }

//         string selectedHall = halls[hallChoice - 1];

//         Console.Clear();

//         Console.WriteLine("=====================================");
//         Console.WriteLine("       WELCOME TO " +
//             selectedHall.ToUpper() + "!");
//         Console.WriteLine("=====================================");
//         Console.WriteLine("       Butwal Cinema Booking");
//         Console.WriteLine("=====================================");

//         Console.WriteLine("\nMovies available at " + selectedHall + ":\n");

//         int movieCount = 0;

//         for (int i = 0; i < movies.Length; i++)
//         {
//             if (movies[i].HallName == selectedHall)
//             {
//                 movies[i].DisplayMovie(++movieCount);
//             }
//         }

//         if (movieCount == 0)
//         {
//             Console.WriteLine("No movies available at this hall.");
//             return;
//         }

//         Console.Write("Choose movie number: ");

//         if (!int.TryParse(Console.ReadLine(), out int movieChoice) ||
//             movieChoice < 1 || movieChoice > movieCount)
//         {
//             Console.WriteLine("Invalid movie selection.");
//             return;
//         }

//         Movie selectedMovie = null;
//         int currentNumber = 0;

//         for (int i = 0; i < movies.Length; i++)
//         {
//             if (movies[i].HallName == selectedHall)
//             {
//                 currentNumber++;

//                 if (currentNumber == movieChoice)
//                 {
//                     selectedMovie = movies[i];
//                     break;
//                 }
//             }
//         }

//         if (selectedMovie == null || !selectedMovie.IsAvailable)
//         {
//             Console.WriteLine("Sorry, this movie is unavailable.");
//             return;
//         }

//         Console.WriteLine("\nEnter your customer details:");

//         Console.Write("Customer ID: ");
//         if (!int.TryParse(Console.ReadLine(), out int id))
//         {
//             Console.WriteLine("Invalid customer ID.");
//             return;
//         }

//         Console.Write("Full Name: ");
//         string name = Console.ReadLine() ?? "";

//         Console.Write("Age: ");
//         if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
//         {
//             Console.WriteLine("Invalid age.");
//             return;
//         }

//         Console.Write("Phone Number: ");
//         string phone = Console.ReadLine() ?? "";

//         Customer customer = new Customer(
//             id,
//             name,
//             age,
//             phone,
//             selectedMovie.MovieName,
//             selectedHall,
//             selectedMovie.Price
//         );

//         Console.Clear();

//         Console.WriteLine("=====================================");
//         Console.WriteLine("       WELCOME TO " +
//             selectedHall.ToUpper() + "!");
//         Console.WriteLine("=====================================");

//         customer.DisplayCustomer();

//         Console.WriteLine("\nThank you for choosing " + selectedHall + "!");
//         Console.WriteLine("\nPress Enter to exit.");
//         Console.ReadLine();
//     }
// }


// Movie[] movies = new Movie[5]
// {
//     new Movie("Inception", "2h 28m", 12.50),
//     new Movie("Avatar: The Way of Water", "3h 12m", 15.00),
//     new Movie("The Dark Knight", "2h 32m", 10.00),
//     new Movie("Interstellar", "2h 49m", 11.50),
//     new Movie("Spider-Man: Across the Spider-Verse", "2h 20m", 13.00)
// };


// Console.WriteLine("========================================");
// Console.WriteLine("    WELCOME TO THE MOVIE BOOKING APP    ");
// Console.WriteLine("========================================\n");

// Console.Write("Enter Customer Name: ");
// string customerName = Console.ReadLine()??"";

// Console.Write("Enter Contact Number: ");
// string contact = Console.ReadLine()??"";

// Console.WriteLine("\n--- Available Movies ---");
// for (int i = 0; i < movies.Length; i++)
// {
//     Console.WriteLine($"{i + 1}. {movies[i].Name} | Duration: {movies[i].Duration} | Price: ${movies[i].Price}");
// }

// int choice = 0;
// while (choice < 1 || choice > movies.Length)
// {
//     Console.Write($"\nSelect a movie (1-{movies.Length}): ");
//     if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > movies.Length)
//     {
//         Console.WriteLine("Invalid choice. Please select a valid movie number.");
//     }
// }

// Movie chosenMovie = movies[choice - 1];

// Console.Write("Enter Show Date (e.g., YYYY-MM-DD): ");
// string date = Console.ReadLine()??"";

// Console.Write("Enter Show Time (e.g., 06:30 PM): ");
// string time = Console.ReadLine()??"";

// Customer customer = new Customer(customerName, contact, chosenMovie, date, time);
// customer.PrintTicket();






// class Movie{
//     public string Name;
//     public string Duration;
//     public double Price;

//     public Movie(string name, string duration, double price)
//     {
//         Name = name;
//         Duration = duration;
//         Price = price;
//     }
// }

// class Customer
// {
//     public string Name;
//     public string Contact;
//     public Movie SelectedMovie;
//     public string ShowDate;
//     public string ShowTime;

//     public Customer(string name, string contact, Movie selectedMovie, string showDate, string showTime)
//     {
//         Name = name;
//         Contact = contact;
//         SelectedMovie = selectedMovie;
//         ShowDate = showDate;
//         ShowTime = showTime;
//     }

//     public void PrintTicket()
//     {
//         Console.WriteLine("\n========================================");
//         Console.WriteLine("          BOOKING CONFIRMATION          ");
//         Console.WriteLine("========================================");
//         Console.WriteLine($"Customer Name  : {Name}");
//         Console.WriteLine($"Contact Number : {Contact}");
//         Console.WriteLine($"Movie Selected : {SelectedMovie.Name}");
//         Console.WriteLine($"Movie Duration : {SelectedMovie.Duration}");
//         Console.WriteLine($"Ticket Price   : ${SelectedMovie.Price}");
//         Console.WriteLine($"Show Date      : {ShowDate}");
//         Console.WriteLine($"Show Time      : {ShowTime}");
//         Console.WriteLine("========================================");
//         Console.WriteLine("   Thank you for booking with us!      ");
//         Console.WriteLine("========================================");
//     }
// }

// class student 
// {
//     private int age;
//     public void SetAge(int newAge)
//     {
// if (newAge >= 0 && newAge <120) age = newAge;
// else Console.WriteLine("Invalid age");
//     }
//     public int GetAge() { return age; }
// }
// Student s = new Student();
// s.SetAge(22);
// Console.WriteLine(s.GetAge()); // 22


// using System;

// class Student
// {
//     private int age;

//     public void SetAge(int newAge)
//     {
//         if (newAge >= 0 && newAge < 120)
//         {
//             age = newAge;
//         }
//         else
//         {
//             Console.WriteLine("Invalid age");
//         }
//     }

//     public int GetAge()
//     {
//         return age;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.SetAge(22);

//         Console.WriteLine(s.GetAge());
//     }
// }

Person p = new Person();
p.Name ="Shyam";
Console.WriteLine(p.Name);

class Person
{
    private string name = "";
    public string Name
{
    get { return name; }
    set { name = value; }
}
}
