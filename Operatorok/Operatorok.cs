using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    internal class Operatorok
    {
        int elsoOperandus;
        string szovegesOperator;
        int masodikOperandus;

        public Operatorok(int elsoOperandus, string szovegesOperator, int masodikOperandus)
        {
            this.elsoOperandus = elsoOperandus;
            this.szovegesOperator = szovegesOperator;
            this.masodikOperandus = masodikOperandus;
        }

        public int ElsoOperandus { get => elsoOperandus; }
        public string SzovegesOperator { get => szovegesOperator; }
        public int MasodikOperandus { get => masodikOperandus; }

        public static string Szamol(string kifejezes)
        {
            try
            {
                string[] kifejezesSplit = kifejezes.Split();
                switch (kifejezesSplit[1])
                {
                    case "mod":
                        return $"{kifejezes} = {Convert.ToDouble(kifejezesSplit[0]) % Convert.ToDouble(kifejezesSplit[2])}";
                    case "/":
                        return $"{kifejezes} = {Convert.ToDouble(kifejezesSplit[0]) / Convert.ToDouble(kifejezesSplit[2])}";
                    case "div":
                        return $"{kifejezes} = {int.Parse(kifejezesSplit[0]) / int.Parse(kifejezesSplit[2])}";
                    case "-":
                        return $"{kifejezes} = {Convert.ToDouble(kifejezesSplit[0]) - Convert.ToDouble(kifejezesSplit[2])}";
                    case "*":
                        return $"{kifejezes} = {Convert.ToDouble(kifejezesSplit[0]) * Convert.ToDouble(kifejezesSplit[2])}";
                    case "+":
                        return $"{kifejezes} = {Convert.ToDouble(kifejezesSplit[0]) + Convert.ToDouble(kifejezesSplit[2])}";
                    default:
                        return $"{kifejezes} = Hibás operátor!";
                }
            }
            catch (Exception)
            {
                return $"{kifejezes} = Egyéb hiba!";
                throw;
            }

        }
    }
}
