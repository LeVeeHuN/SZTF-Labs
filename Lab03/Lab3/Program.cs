using Lab3.f2;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jozsa David github
            // jozdavab


            User[] users =
            {
                new User("Lajos", 5),
                new User("Magdi", 2),
                new User("Smth", 3.5),
                new User("Gab", 3.5)
            };

            Array.Sort(users);

            foreach(User u in users)
            {
                Console.WriteLine(u);
            }
        }

        static bool Fizetes(IFizetoEszkoz[] eszkozok)
        {
            foreach (IFizetoEszkoz e in eszkozok)
            {
                return e.Fizet(200);
            }
            return false;
        }

        static bool EllenorzottFizetes(IFizetoEszkoz[] eszkozok, string name)
        {
            foreach (IFizetoEszkoz e in eszkozok)
            {
                if (e is ITulajdon && (e as ITulajdon).Tulajdonos.Equals(name)) return e.Fizet(200);
            }
            return false;
        }
    }
}