using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] arrElec = new Electrodomestico[10];

            Lavadora lav = new Lavadora(100, 8);
            arrElec[0] = lav;
            lav = new Lavadora(30);
            arrElec[1] = lav;
            lav = new Lavadora(75, 6);
            arrElec[2] = lav;
            lav = new Lavadora(50);
            arrElec[3] = lav;
            Television tv = new Television(350, 15);
            arrElec[4] = tv;
            tv = new Television(600, 30);
            arrElec[5] = tv;
            tv = new Television(65, true);
            arrElec[6] = tv;
            Electrodomestico elec = new Electrodomestico(30, 1);
            arrElec[7] = elec;
            elec = new Electrodomestico(30, "rojo", 'G', 5);
            arrElec[8] = elec;
            elec = new Electrodomestico(50, 3);
            arrElec[9] = elec;

            for (int i = 0; i < arrElec.Length; i++)
            {

                if (arrElec[i] is Lavadora)
                {
                    arrElec[i].Preciofinal();
                }
                else
                {
                    if (arrElec[i] is Television)
                    {
                        arrElec[i].Preciofinal();
                    }
                    else
                    {
                        if (arrElec[i] is Electrodomestico)
                        {
                            arrElec[i].Preciofinal();
                        }
                    }
                }
            }
            double sumLav = 0;
            double sumTv= 0;
            double sumElec = 0;
            for (int i = 0; i < arrElec.Length; i++)
            {
                if (arrElec[i] is Lavadora)
                {
                    sumLav = sumLav + arrElec[i].PrecioBase;
                    sumElec = sumElec + arrElec[i].PrecioBase;
                }
                else
                {
                    if (arrElec[i] is Television)
                    {
                        sumTv= sumTv+ arrElec[i].PrecioBase;
                        sumElec = sumElec + arrElec[i].PrecioBase;
                    }
                    else
                    {
                        if (arrElec[i] is Electrodomestico)
                        {
                            sumElec = sumElec + arrElec[i].PrecioBase;
                        }
                    }
                }
            }
            Console.WriteLine("Lavadoras: "+sumLav);
            Console.WriteLine("Televisores: " + sumTv);
            Console.WriteLine("Electrodomesticos: " + sumElec);

            Console.ReadKey();

        }
    }
}
