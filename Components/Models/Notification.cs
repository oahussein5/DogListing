namespace DogListing.Components.Models
{
    public class Notification
    {
        // Properties
        public int NotificationID { get; set; } // Unique identifier
        public int UserID { get; set; } // ID of the user to receive the notification
        public int? DogID { get; set; } // Optional: ID of the dog that triggered the notification
        public required string Message { get; set; } // Notification message

        // Constructor
        //public Notification(int notificationID, int userID, string message, int? dogID = null)
        //{
        //    NotificationID = notificationID;
        //    UserID = userID;
        //    Message = message;
        //    DogID = dogID;
        //}

        // Function
        //public void SendNotification()
        //{
        //    // Simulate sending a notification
        //    Console.WriteLine($"Notification Sent!");
        //    Console.WriteLine($"To User ID: {UserID}");
        //    if (DogID.HasValue)
        //    {
        //        Console.WriteLine($"Related to Dog ID: {DogID.Value}");
        //    }
        //    Console.WriteLine($"Message: {Message}");
        //}
    }
}
