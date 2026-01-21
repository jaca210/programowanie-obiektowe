namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektrycznySamochod auto1 = new ElektrycznySamochod();

            auto1.Start();
            auto1.Laduj();
            auto1.Jedz();
        }
    }
}
