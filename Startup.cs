using Microsoft.AspNet.Builder;

namespace BerekenBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je lengte in meter in");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef je gewicht in");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Je Bmi is " + berekenBMI(lengte, gewicht) + " Je BSA is " + berekenBSA(lengte, gewicht));
            Console.ReadKey();
        }
        public static double berekenBMI(double lengte, double gewicht)
        {
            return (gewicht / (lengte * lengte));
        
        }
        public static double berekenBSA(double lengte, double gewicht)
        {
            return  0.024265 * Math.Pow((lengte *100), 0.3964) * Math.Pow(gewicht, 0.5378);
        }
    }
}
