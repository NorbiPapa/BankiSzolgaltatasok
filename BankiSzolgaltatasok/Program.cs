namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tulajdonos tulajdonos1 = new Tulajdonos("Tök Ödön");
            Tulajdonos tulajdonos2 = new Tulajdonos("Káromló Krisztián");
            Tulajdonos tulajdonos3 = new Tulajdonos("Ku Kíra");

            Bank bank = new Bank();

            try
            {
                bank.szamlanyitas(-1, tulajdonos1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Számla szamla1 = bank.szamlanyitas(0, tulajdonos1);
            szamla1.Befizet(1301);

            Számla szamla2 = bank.szamlanyitas(10000, tulajdonos2);
            szamla2.Befizet(5050);

            Számla szamla3 = bank.szamlanyitas(2000, tulajdonos3);
            szamla3.Befizet(9000);
            szamla3.Befizet(5000);

            Számla szamla4 = bank.szamlanyitas(3000, tulajdonos3);
            szamla4.Befizet(4500);



            Console.WriteLine("Új kártya igénylése");
            Kártya kartya1 = szamla1.ÚjKártya("6666 7777 8888 9999");
            Console.WriteLine($"Kártyaszám: {kartya1.KartyaSzam} Tulajdonos: {kartya1.Tulajdonos.Nev}");
            Console.WriteLine("Vásárlás");
            Console.WriteLine($"Egyenleg vásárlás előtt: {szamla1.AktualisEgyenleg} ft");
            if (kartya1.Vasarlas(10001))
            {
                Console.WriteLine("Sikeres vásárlás");
                Console.WriteLine($"Egyenleg vásárlás után: {szamla1.AktualisEgyenleg} ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen vásárlás\n");
            }




            MegtakarításiSzámla sz = (MegtakarításiSzámla)szamla1;
            Console.WriteLine("Kamatjóváírás");
            Console.WriteLine($"Egyenleg kamatjóváírás előtt: {sz.AktualisEgyenleg} Ft");
            sz.KamatJóváírás();
            sz.KamatJóváírás();
            Console.WriteLine($"Egyenleg kamatjóváírás után: {sz.AktualisEgyenleg} Ft\n");




            Console.WriteLine("Pénz kivétel hitelszámláról");
            Console.WriteLine($"Egyenleg pénzkivétel előtt: {szamla2.AktualisEgyenleg} Ft");
            if (szamla2.Kivesz(15001))
            {
                Console.WriteLine("Sikeres pénzkivétel");
                Console.WriteLine($"Egyenleg pénzkivétel után: {szamla2.AktualisEgyenleg} Ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen pénzkivétel\n");
            }




            Console.WriteLine("Pénz kivétel megtakarításszámláról");
            Console.WriteLine($"Egyenleg pénzkivétel előtt: {szamla1.AktualisEgyenleg} Ft");
            if (szamla1.Kivesz(11000))
            {
                Console.WriteLine("Sikeres pénzkivétel");
                Console.WriteLine($"Egyenleg pénzkivétel után: {szamla1.AktualisEgyenleg} Ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen pénzkivétel\n");
            }


            Console.WriteLine($"Bank által kiosztott hitelkeret összege: {bank.ÖsszHitelkeret} Ft\n");

            Console.WriteLine($"{tulajdonos3.Nev} összegyenlege: {bank.GetÖsszEgyenleg(tulajdonos3)} Ft\n");

            Console.WriteLine($"{tulajdonos3.Nev} legnagyobb egyenlege: {bank.GetLegnagyobbEgyenlegűSzámla(tulajdonos3).AktualisEgyenleg} Ft\n");

        }
    }
}