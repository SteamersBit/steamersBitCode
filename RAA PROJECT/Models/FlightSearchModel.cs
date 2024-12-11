namespace RAA_PROJECT.Models
{
    public class FlightSearchModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime? DepartDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string CabinClass { get; set; }
        public List<string> PassengerTypes { get; set; } = new List<string>
        {
            "Student", "Senior Citizen", "Armed Forces", "Doctors and Nurses"
        };
        public List<string> CabinClasses { get; set; } = new List<string>
        {
            "Economy", "Premium Economy", "Business", "First Class"
        };
    }
}
