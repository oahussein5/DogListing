namespace DogListing.Components.Models
{
    public class Application
    {
        // Properties
        public int ApplicationID { get; set; } // Unique identifier for the application
        public int UserID { get; set; } // ID of the user submitting the application
        public int DogID { get; set; } // ID of the dog being applied for
        public required string Status { get; set; } // Current status (e.g., pending, approved, rejected)
        public DateTime SubmittedDate { get; set; } // Date of application submission

        // Constructor
        //public Application(int applicationID, int userID, int dogID)
        //{
        //    ApplicationID = applicationID;
        //    UserID = userID;
        //    DogID = dogID;
        //    Status = "Pending"; // Default status
        //    SubmittedDate = DateTime.Now; // Set submission date to current date and time
        //}

        // Functions
        //public void SubmitApplication()
        //{
        //    // Simulate submission logic
        //    Console.WriteLine($"Application ID: {ApplicationID}");
        //    Console.WriteLine($"User ID: {UserID} applied for Dog ID: {DogID}");
        //    Console.WriteLine($"Status: {Status}");
        //    Console.WriteLine($"Submitted Date: {SubmittedDate}");
        //    Console.WriteLine("Application submitted successfully!");
        //}

        //public void ReviewApplication(string newStatus)
        //{
        //    if (newStatus.Equals("approved", StringComparison.OrdinalIgnoreCase) ||
        //        newStatus.Equals("rejected", StringComparison.OrdinalIgnoreCase))
        //    {
        //        Status = newStatus;
        //        Console.WriteLine($"Application ID: {ApplicationID} has been {newStatus}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid status. Please use 'approved' or 'rejected'.");
        //    }
        //}
    }
}
