namespace Activity9
{
    class Program
    {

        
        // test the methods
        public static void Main(string[] args)
        {
            MethodSigniture signiture = new MethodSigniture();

            Console.WriteLine("The sum of 95 + 5 = " +  MethodSigniture.sum(95, 5));

            Console.WriteLine("The average of (10 + 20 + 30 + 40 + 50) / 5  =  " + MethodSigniture.average(10, 20, 30, 40, 50));

            Console.WriteLine("The Sum of two randoms, number1 and number2  =  " + MethodSigniture.sumRandom());

            Console.WriteLine("The sum of (50, 70, 90) / 3 = " + MethodSigniture.sumDivsible(123, 456, 789));

            Console.WriteLine("String with fewer characters is: " + MethodSigniture.stringLength("Hi", "Hello"));

            Console.WriteLine("The largest from 50, 70, 90, 150, 175, 100 is: " + MethodSigniture.arrLarge(new double[] { 50, 70, 90, 100, 150, 175 }));

            Console.WriteLine("Array os 50 integer value = { " + MethodSigniture.arrFifty() + "}");

            Console.WriteLine("Check if the  bool have the same value " + MethodSigniture.sameValue(true, true));

            Console.WriteLine("The product of 90 + 5.5: " + MethodSigniture.product(90, 5.5));

            Console.WriteLine("The average two-dimentional values of { 50, 70, 90, 100, 150, 175 } is: " + MethodSigniture.arr2DAverage(new double[,] { { 50, 70, 90, 100, 150, 175 } }));


        }
    }

}
