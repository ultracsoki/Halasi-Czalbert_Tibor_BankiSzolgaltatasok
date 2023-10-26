namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Halasi-Czalbert Tibor

            Tulajdonos tulajdonos1 = new Tulajdonos("Szabó Ágoston");
            Tulajdonos tulajdonos2 = new Tulajdonos("Nagy Gréta");
            Tulajdonos tulajdonos3 = new Tulajdonos("Kis Róbert");
            Tulajdonos tulajdonos4 = new Tulajdonos("Puskás Martin");

            Bank bank = new Bank();

            bank.SzamlaNyitas(tulajdonos1, 200000);
            bank.SzamlaNyitas(tulajdonos1, 0);
            bank.SzamlaNyitas(tulajdonos1, 350000);
            bank.SzamlaNyitas(tulajdonos2, 0);
            bank.SzamlaNyitas(tulajdonos2, 12000);
            bank.SzamlaNyitas(tulajdonos3, 0);
            bank.SzamlaNyitas(tulajdonos4, 20000);
            bank.SzamlaNyitas(tulajdonos4, 56000);
            Console.WriteLine(bank.GetOsszEgyenleg(tulajdonos1)); 
            Console.WriteLine(bank.GetOsszEgyenleg(tulajdonos2)); 
            Console.WriteLine(bank.GetOsszEgyenleg(tulajdonos3)); 
            Console.WriteLine(bank.GetOsszEgyenleg(tulajdonos4)); 
            bank.GetLegnagyobbEgyenleguSzamla(tulajdonos1);
            bank.GetLegnagyobbEgyenleguSzamla(tulajdonos2);
            bank.GetLegnagyobbEgyenleguSzamla(tulajdonos3);
            bank.GetLegnagyobbEgyenleguSzamla(tulajdonos4);
            Console.WriteLine($"Össz hitelkeret: {bank.OsszHitelkeret}");

            Console.ReadKey();
        }
    }
}