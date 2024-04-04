namespace Lab_0318
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Courier c = new Courier(15);
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new FragileParcel(1200, "Frag 1 út", Alignment.Horizontal));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new FragileParcel(1500, "Frag 5 utca", Alignment.Vertical));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new FragileParcel(500, "Frag sok tej", Alignment.Vertical));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new FragileParcel(100, "Frag CS2 lessgo", Alignment.Vertical));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));
            c.PickUpItem(new FragileParcel(1200, "Frag 69 utca", Alignment.Horizontal));
            c.PickUpItem(new FragileParcel(5, "Frag 420 tér", Alignment.Horizontal));
            c.PickUpItem(new NormalParcel(1200, "dasasd"));

            IDeliverable[] sortedFrags = c.FragilesSorted();
            for (int i = 0; i < sortedFrags.Length; i++)
            {
                Console.WriteLine(sortedFrags[i].ToString());
            }
        }
    }
}