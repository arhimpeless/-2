namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double z;
            double k;
            x = Num("x");
            z = Num("z");
            k = Num("k");
            GtAnswer(x, z, k);        
        }
        static double Num(string str)
        {
            char charkeybord;
            bool firstnumber = true;
            bool tochka = false;
            ConsoleKeyInfo keybord;
            string stringFromConsole = "";
            Console.Write("Введите число {0}: ", str);
                //while ((keybord = Console.ReadKey(true)).Key != ConsoleKey.Enter)
                while (true)
                {
                keybord = Console.ReadKey(true);
                if (keybord.Key == ConsoleKey.Enter)
                {
                    break;
                }
                charkeybord = keybord.KeyChar;
                if (keybord.Key == ConsoleKey.Backspace && stringFromConsole.Length > 0)
                {
                    Console.Write("\b \b");
                    int dlinastroki = stringFromConsole.Length;
                    str.Remove(dlinastroki, 1);
                }
                if (charkeybord == '-' && firstnumber)
                {
                    Console.Write("-");
                    stringFromConsole = "-" + stringFromConsole;
                    firstnumber = false;
                }
                if (Char.IsDigit(charkeybord))
                {
                    Console.Write(charkeybord);
                    stringFromConsole += charkeybord;
                    firstnumber = false;
                }
                if ((charkeybord == ',' || charkeybord == '.') && !tochka)
                {
                    if (firstnumber)
                    {
                        firstnumber = false;
                        Console.Write('0');
                    }
                    Console.Write(',');
                    stringFromConsole += ',';
                    tochka = true;
                }
                }
                if (stringFromConsole == "0" || stringFromConsole == "" || stringFromConsole == null)
                {
                Console.Write(0);
                return 0;
                }
                double.TryParse(stringFromConsole, out double allnumber);
                return allnumber;
        }
        static void GtAnswer(double x, double z, double k)
        {
            if (x < 0)
            {
            Console.WriteLine("\nВнимание, х >= 0!");
            return;
            }
            if (k == 0)
            {
            Console.WriteLine("\nВнимание, k != 0!");
            return;
            }
            if (x >= 0 && k != 0 )
            {
            Console.WriteLine($"Результат y = {(Math.Sqrt(2*x+3*Math.Pow(x, 2)+4*Math.Pow(x, 3))+(19*z/15*k))/(Math.Sqrt(2*z+Math.Pow(x, 4))-24*z*(x+7))}");
            return;
            }
            Console.WriteLine("Хорошо порешали.");
        }
    }
}