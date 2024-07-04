namespace Latih9_ProsedurFungsi
{
    internal class Program
    {

        static void TglSkrg() // Prosedur menampilkan Tanggal Sekarang
        {
            var Skrg = DateTime.Now;
            Console.WriteLine($"Tanggal Sekarang Adalah = {Skrg}");
        }

        static int Kali(int a, int b) // Function kali
        {
            return a * b;
        }

        static bool apakahGenap(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
           
        }
        static void Main(string[] args)
        {
            TglSkrg(); // Iki Memanggil Prosedur ya:)
            Console.WriteLine(Kali(4,6)); // Ini memanggil Function Kali
            Console.WriteLine(apakahGenap(7)); // ini cek bilangan

        }
    }
}
