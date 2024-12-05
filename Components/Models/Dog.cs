namespace DogListing.Components.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string ImageUrl { get; set; } // URL for dog image
        public bool IsAdopted { get; set; } // Whether the dog is already adopted
    }
}
