namespace Operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Operatorok> operatorokLista = new List<Operatorok>();

            StreamReader streamReader = new StreamReader("kifejezesek.txt");
            while (!streamReader.EndOfStream)
            {
                string[] sor = streamReader.ReadLine().Split();
                operatorokLista.Add(new Operatorok(int.Parse(sor[0]), sor[1], int.Parse(sor[2])));
            }
            streamReader.Close();

            Console.WriteLine($"2. feladat: Kifejezések száma: {operatorokLista.Count}");
            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {operatorokLista.Count(x => x.SzovegesOperator == "mod")}");
            Console.WriteLine($"4. feladat: {(operatorokLista.Any(x => x.ElsoOperandus % 10 == 0 && x.MasodikOperandus % 10 == 0) ? "Van ilyen kifejezés!" : "Nincs ilyen kifejezés!")}");
            Console.WriteLine("5. feladat: Statisztika");
            Console.WriteLine($"\tmod -> {operatorokLista.Count(x => x.SzovegesOperator == "mod")} db");
            Console.WriteLine($"\t/ -> {operatorokLista.Count(x => x.SzovegesOperator == "/")} db");
            Console.WriteLine($"\tdiv -> {operatorokLista.Count(x => x.SzovegesOperator == "div")} db");
            Console.WriteLine($"\t- -> {operatorokLista.Count(x => x.SzovegesOperator == "-")} db");
            Console.WriteLine($"\t* -> {operatorokLista.Count(x => x.SzovegesOperator == "*")} db");
            Console.WriteLine($"\t+ -> {operatorokLista.Count(x => x.SzovegesOperator == "+")} db");
            string bekeres;
            do
            {
                Console.Write("7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                bekeres = Console.ReadLine();
                if (bekeres != "vége")
                {
                    Console.WriteLine($"\t{Operatorok.Szamol(bekeres)}");
                }
            } while (bekeres != "vége");
            Console.WriteLine("8. feladat: eredmenyek.txt");
            StreamWriter streamWriter = new StreamWriter("eredmenyek.txt");
            for (int index = 0; index < operatorokLista.Count; index++)
            {
                streamWriter.WriteLine($"{Operatorok.Szamol(operatorokLista[index].ElsoOperandus + " " + operatorokLista[index].SzovegesOperator + " " + operatorokLista[index].MasodikOperandus)}");
            }
            streamWriter.Close();
        }
    }
}