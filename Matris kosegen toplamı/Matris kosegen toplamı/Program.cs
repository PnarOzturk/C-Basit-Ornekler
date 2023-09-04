using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Matris_kosegen_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {

             

                Console.WriteLine("\n 2 boyutlu dizinin olusmasini istediniz eleman sayisini giriniz : ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] dizi = new int[n, n];
                Console.WriteLine("\n\n");
                Random rnd = new Random();

                int i, j;
                int ana = 0, asal = 0; //ana: ana köşegen, asal: asal/ters kösegen


                for (i = 0; i < dizi.GetLength(0); i++) //Dizi satırı kadar 
                {
                    for (j = 0; j < dizi.GetLength(1); j++) //Dizi sütunu kadar
                    {
                        dizi[i, j] = rnd.Next(1, 11);

                        Console.Write(dizi[i, j] + "\t");


                        if (i == j)//ana köşegen kuralı
                        {
                            ana += dizi[i, j];
                        }
                        if (i + j == (n-1))//matris eleman sayisinin 1 eksiğini yazıyoruz.ters köşegen kuralı
                        {
                            asal += dizi[i, j];


                        }
                    }
                    Console.WriteLine(); // Bunu yazmayınca kare matris seklinde yazilmiyor yan yana yazılıyor
                }

            if (n % 2 == 0)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Ana köşegen Toplamı = {0}\nTers Köşegen Toplamı ={1}", ana, asal);
                Console.WriteLine("kösegenlerindeki toplam eleman sayisi : " + (ana + asal));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Ana köşegen Toplamı = {0}\nTers Köşegen Toplamı ={1}", ana, asal);
                Console.WriteLine("kösegenlerindeki toplam eleman sayisi : " + (ana + (asal - dizi[(n/2)+1,(n/2)+1])));
                Console.ReadKey();
            }





        }
    }
 }

