namespace DogListing.Components.Models
{
    public class Dog
    {
        // Properties
        public int DogID { get; set; } // Unique identifier
        public required string Name { get; set; } // Name of the dog
        public required string Breed { get; set; } // Breed of the dog
        public int Age { get; set; } // Age of the dog
        public required string Size { get; set; } // Size (e.g., small, medium, large)
        public required string Location { get; set; } // Shelter location
        public required string Description { get; set; } // General description
        public required string Temperament { get; set; } // Behavior information
        public required string MedicalHistory { get; set; } // Medical details
        public required string SpecialRequirements { get; set; } // Special needs
        public required string AdoptionStatus { get; set; } // Current status (e.g., Available, Adopted)
        public required List<string> Photos { get; set; } // List of photo URLs

        // Constructor
        //public Dog()
        //{
        //    Photos = new List<string>(); // Initialize photo list
        //}

        // Functions
        //public bool SearchDogs(string criteria)
        //{
        //    // Example search logic (this can be expanded based on actual criteria)
        //    return Name.Contains(criteria, StringComparison.OrdinalIgnoreCase) ||
        //           Breed.Contains(criteria, StringComparison.OrdinalIgnoreCase) ||
        //           Description.Contains(criteria, StringComparison.OrdinalIgnoreCase);
        //}

        //public string GetDogDetails()
        //{
        //    return $"ID: {DogID}\n" +
        //           $"Name: {Name}\n" +
        //           $"Breed: {Breed}\n" +
        //           $"Age: {Age}\n" +
        //           $"Size: {Size}\n" +
        //           $"Location: {Location}\n" +
        //           $"Description: {Description}\n" +
        //           $"Temperament: {Temperament}\n" +
        //           $"Medical History: {MedicalHistory}\n" +
        //           $"Special Requirements: {SpecialRequirements}\n" +
        //           $"Adoption Status: {AdoptionStatus}\n" +
        //           $"Photos: {string.Join(", ", Photos)}";
        //}

        //public void MarkAsAdopted()
        //{
        //    AdoptionStatus = "Adopted";
        //}
    }
}
