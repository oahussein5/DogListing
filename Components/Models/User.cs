namespace DogListing.Components.Models
{
    public class User
    {
        // Properties
        public int UserID { get; set; } // Unique identifier
        public required string Name { get; set; } // User's name
        public required string Email { get; set; } // Email address
        public required string Password { get; set; } // Encrypted password
        public required List<int> Favorites { get; set; } // List of favorite dog IDs
        public bool NotificationPreferences { get; set; } // Notification flag
        public required string VolunteerStatus { get; set; } // Volunteer application status

        // Constructor
        //public User()
        //{
        //    Favorites = new List<int>(); // Initialize favorites list
        //}

        // Functions
        //public void CreateAccount(string name, string email, string password)
        //{
        //    Name = name;
        //    Email = email;
        //    Password = EncryptPassword(password);
        //    NotificationPreferences = false; // Default preference
        //    VolunteerStatus = "None"; // Default status
        //    Console.WriteLine("Account created successfully!");
        //}

        // public bool Login(string email, string password)
        //{
        //    if (Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
        //        Password == EncryptPassword(password))
        //    {
        //        Console.WriteLine("Login successful!");
        //        return true;
        //    }
        //    Console.WriteLine("Login failed: Invalid email or password.");
        //    return false;
        //}

        //public void ManageFavorites(int dogID, string action)
        //{
        //    if (action.Equals("add", StringComparison.OrdinalIgnoreCase))
        //    {
        //        if (!Favorites.Contains(dogID))
        //        {
        //            Favorites.Add(dogID);
        //            Console.WriteLine($"Dog ID {dogID} added to favorites.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Dog is already in favorites.");
        //        }
        //    }
        //    else if (action.Equals("remove", StringComparison.OrdinalIgnoreCase))
        //    {
        //        if (Favorites.Contains(dogID))
        //        {
        //            Favorites.Remove(dogID);
        //            Console.WriteLine($"Dog ID {dogID} removed from favorites.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Dog ID not found in favorites.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid action. Use 'add' or 'remove'.");
        //    }
        //}

        //public void EnableNotifications(bool criteria)
        //{
        //    NotificationPreferences = criteria;
        //    Console.WriteLine($"Notifications are now {(criteria ? "enabled" : "disabled")}.");
        //}

        //public void ApplyToVolunteer(string application)
        //{
        //    VolunteerStatus = "Pending";
        //    Console.WriteLine($"Volunteer application submitted: {application}");
        //}

        //// Helper method to simulate password encryption
        //private string EncryptPassword(string password)
        //{
        //    // Simple encryption simulation for example purposes
        //    var base64Encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        //    return base64Encoded;
        //}
    }
}
