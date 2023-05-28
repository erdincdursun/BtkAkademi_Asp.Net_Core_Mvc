namespace BtkAkademi.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;  //IEnumerable : Numara edilebilir, her seferinde bir örnek verilebilir.

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}