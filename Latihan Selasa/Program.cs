using System;
using System.Collections.Generic;

namespace Latihan_Selasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT KALIMAT : ");
            var Kalimat = Console.ReadLine();

            var JumlahSpasi = 0;
            
            while (JumlahSpasi <= 2) // WHILE MASIH SALAH
            {
                
                Console.Write("INPUT KALIMAT : ");
                Kalimat = Console.ReadLine();
                Kalimat = Kalimat.ToUpper();

                for (int i = 0; i < Kalimat.Length; i++)
                {
                    if (Kalimat[i] == ' ')
                        JumlahSpasi++; 
                }

                if(JumlahSpasi <= 2)
                    Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");

            } // ^^ MASIH SALAH
            
            Console.Clear();
            Console.WriteLine("INPUT KALIMAT : " + Kalimat);

            Console.Write("INPUT KATA : ");
            var Kata = Console.ReadLine();
            while (Kata.Length <= 1)
            {
                Console.WriteLine("KATA PADA KATA KURANG PANJANG");
                Console.Write("INPUT KATA : ");
                Kata = Console.ReadLine();
            }
            Kata = Kata.ToUpper();
            Console.Clear();
            Console.WriteLine("INPUT KALIMAT : " + Kalimat);
            Console.WriteLine("INPUT KATA : " + Kata);


            Console.WriteLine("STATISTIK HURUF : "); // --> STATISTIK HURUF
            char[] IsiKalimat = Kalimat.ToCharArray();
            Array.Sort(IsiKalimat);

            var HitungHurufMuncul = 1;
            var HitungJumlahHuruf = 0;
            for (int i = 1; i < IsiKalimat.Length; i++)
            {
                if (IsiKalimat[i] == IsiKalimat[i - 1])
                    HitungHurufMuncul++;
                else
                {
                    if (IsiKalimat[i - 1] != ' ')
                        Console.WriteLine($"{IsiKalimat[i - 1]} = {HitungHurufMuncul}");
                    HitungHurufMuncul = 1;
                }

                HitungJumlahHuruf++;
            }

            Console.WriteLine("\nSTATISTIK KATA : "); //--> STATISTIK KATA
            var Di_Cari_Kata = 0;
            while (Kalimat.Contains(Kata))
            {
                Di_Cari_Kata++;
                Kalimat = Kalimat.Remove(Kalimat.IndexOf(Kata), Kata.Length);
            }

            Console.WriteLine(Kata + " = " + Di_Cari_Kata + " Kata\n");
            Console.WriteLine("JUMLAH HURUF = " + HitungJumlahHuruf);
        }
    }
}
