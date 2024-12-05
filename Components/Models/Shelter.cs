namespace DogListing.Components.Models
{
    public class Shelter
    {
        // Properties
        public int ShelterID { get; set; } // Unique identifier
        public required string Name { get; set; } // Name of the shelter
        public required string Address { get; set; } // Shelter's address
        public required string ContactInfo { get; set; } // Contact information (email, phone)
        public required List<int> Dogs { get; set; } // List of dog IDs in the shelter

        // Constructor
        //public Shelter()
        //{
        //    Dogs = new List<int>(); // Initialize dogs list
        //}

        // Functions
        //public void ContactShelter(int dogID, int userID)
        //{
        //    // Simulate contacting the shelter about a specific dog
        //    if (Dogs.Contains(dogID))
        //    {
        //        Console.WriteLine($"User {userID} has contacted the shelter '{Name}' regarding Dog ID {dogID}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Dog ID {dogID} is not available at this shelter.");
        //    }
        //}

        //public void ReceiveVolunteerApplication(string application)
        //{
        //    // Simulate processing a volunteer application
        //    Console.WriteLine($"Volunteer application received: {application}");
        //    Console.WriteLine("The shelter will review the application and get back to the applicant.");
        //}
    }
}
