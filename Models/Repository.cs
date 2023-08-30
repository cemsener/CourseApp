using CourseApp.Models;

namespace CourseApp.Controllers
{
    public static class Repository
    {
        private static List<Candidate> applications = new(); //yeni nesil kullanımı
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}