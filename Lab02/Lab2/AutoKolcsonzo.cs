using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Cars;

namespace Lab2
{
    internal sealed class AutoKolcsonzo
    {
        static Random rnd = new Random();

        List<Auto> autok;

        public AutoKolcsonzo()
        {
            autok = new List<Auto>();
        }

        public void AddAuto(Auto auto)
        {
            foreach (Auto a in autok)
            {
                if (a.Rendszam.Equals(auto.Rendszam)) return;
            }
            autok.Add(auto);
        }

        public void RemoveAuto(string rendszam)
        {
            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].Rendszam.Equals(rendszam))
                {
                    autok.RemoveAt(i);
                    break;
                }
            }
        }

        public void printAllCars()
        {
            foreach (Auto a in autok)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public double OsszesFogyazstasa()
        {
            double fogyasztasok = 0;
            foreach (Auto a in autok)
            {
                fogyasztasok += a.Fogyasztas();
            }
            return fogyasztasok;
        }

        public double MindenteherautoRakod()
        {
            double rakodasok = new double();
            foreach (Auto a in autok)
            {
                if (a is Teherauto)
                {
                    rakodasok += (a as Teherauto).Rakodas();
                }
            }
            return rakodasok;
        }

        public void MasodikFelTolt()
        {
            for (int i = (int)autok.Count / 2; i < autok.Count; i++)
            {
                if (autok[i] is TaviranyitosAuto)
                {
                    while ((autok[i] as TaviranyitosAuto).ElemToltottsege < 100)
                    {
                        (autok[i] as TaviranyitosAuto).Elemcsere();
                    }
                }
            }
        }

        public void MakeRandomCars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                // Random adatok mindig
                // Auto
                string plate = RandomPlate();
                int tengelytav = rnd.Next(100, 301);
                DateTime gyartasdatuma = DateTime.Now;
                int loero = rnd.Next(70, 601);
                // Személygépjármű
                int ajtokSzama = rnd.Next(4, 6);
                int szallithatoUtasokSzama = rnd.Next(3, 8);
                // Haszongépjármű
                double hasznossagiHanyados = rnd.NextDouble() * 2;
                // ModellAuto
                int suly = rnd.Next(10, 71);
                int nehezseg = rnd.Next(0, 10);
                // Távirányítós
                KommunikacioFajtaja komm = KommunikacioFajtaja.RADIO;
                int elem = rnd.Next(0, 101);
                // Teherautó
                int utasok = rnd.Next(1, 10);
                int teherbiras = rnd.Next(10_000, 12_001);
                bool ponyvazhato = RandomBool();
                // Sportauto
                int nyomatek = rnd.Next(100, 1_501);
                int sportutasok = rnd.Next(1, 5);
                double rajsag = rnd.NextDouble();
                bool potkerek = RandomBool();
                bool vontathato = RandomBool();
                bool ultetvevan = RandomBool();
                // Luxus auto
                int ar = rnd.Next(20_000_000, 150_000_001);
                bool elektromos = RandomBool();

                int tipusvalaszto = rnd.Next(1, 7);
                if (tipusvalaszto == 1)
                {
                    // Szemelygepjarmu
                    AddAuto(new Szemelygepjarmu(ajtokSzama, szallithatoUtasokSzama, plate, tengelytav, gyartasdatuma, loero));
                }
                else if (tipusvalaszto == 2)
                {
                    // Teher
                    AddAuto(new Teherauto(utasok, teherbiras, ponyvazhato, hasznossagiHanyados, "Haul", plate, tengelytav, gyartasdatuma, loero));
                }
                else if (tipusvalaszto == 3)
                {
                    // Modell
                    AddAuto(new ModellAuto(suly, nehezseg, plate, tengelytav, gyartasdatuma, loero));
                }
                else if (tipusvalaszto == 4)
                {
                    // Taviranyitos
                    AddAuto(new TaviranyitosAuto(komm, elem, suly, plate, tengelytav, gyartasdatuma, loero));
                }
                else if (tipusvalaszto == 5)
                {
                    // Sport
                    AddAuto(new Sportauto(nyomatek, sportutasok, rajsag, potkerek, vontathato, ultetvevan, plate, tengelytav, gyartasdatuma, loero));
                }
                else if (tipusvalaszto == 6)
                {
                    // Luxus
                    AddAuto(new Luxusauto(ar, elektromos, plate, tengelytav, gyartasdatuma, loero));
                }
            }
        }

        string RandomPlate()
        {
            string possibilitiesAbc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string possibilitiesNum = "0123456789";
            string plateAbc = string.Empty;
            string plateNum = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                plateAbc += possibilitiesAbc[rnd.Next(0, possibilitiesAbc.Length)];
                plateNum += possibilitiesNum[rnd.Next(0, possibilitiesNum.Length)];
            }
            string plate = plateAbc + "-" + plateNum;
            return plate;
        }

        bool RandomBool()
        {
            int num = rnd.Next(0, 2);
            if (num == 0) return false;
            return true;
        }
    }
}
