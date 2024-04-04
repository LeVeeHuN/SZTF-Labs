namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoKolcsonzo kolcsonzo = new AutoKolcsonzo();
            kolcsonzo.MakeRandomCars(15);
            kolcsonzo.printAllCars();
        }
    }
}