class Program
{
    static void Main()
    {
        var classes = new[]
        {
              new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
        var allStudents = GetAllStudents(classes);

        Console.WriteLine(string.Join(" ", allStudents));
    }

    static string[] GetAllStudents(Classroom[] classes)
    {

        var allStudents = classes.SelectMany(s => s.Students).ToArray();

        return allStudents;

    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
}
}
