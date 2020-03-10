class Calculator
{
	static void Main (string[] args)
	{
		Console.Title = "Aplikasi Calculator";
            // int a = 10;
            // int b = 6;

            Console.Write("Inputkan Nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
	}
	 
	static int penambahan(int a, int b)
        {
            return a + b;
        }
	static int Pengurangan(int a, int b)
        {
            return a - b;
        }
	static int Perkalian(int a, int b)
        {
            return a * b;
        }
	static int Pembagian(int a, int b)
        {
            return a / b;
        }
}