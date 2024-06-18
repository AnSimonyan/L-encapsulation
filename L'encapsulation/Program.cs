namespace L_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeerEncapsulator beerMaker = new BeerEncapsulator(10, 10);
            beerMaker.AddBeer(350);
            Console.WriteLine( beerMaker.ProduceEncapsulatedBeerBottles(11));

        }
    }
}
