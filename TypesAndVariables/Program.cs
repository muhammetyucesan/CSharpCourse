namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int: -2147483648 ile +2147483647 değerlerinde ve 32 bit.
            int number1 = 10;
            Console.WriteLine("Number1 is {0}", number1);

            // long: -9223372036854775808 ile +9223372036854775807 değerlerinde ve 64 bit.
            long number2 = 200;
            Console.WriteLine("Number2 is {0}", number2);

            // short: -32768 ile +32767 değerlerinde ve 16 bit.
            short number3 = 5;
            Console.WriteLine("Number3 is {0}", number3);

            // byte: 0 ve 255 değerlerinde ve 8 bit.
            byte number4 = 0;
            Console.WriteLine("Number4 is {0}", number4);

            // bool: true ve false değerlerini tutar.
            bool condition = false;

            // char: tek bir karakter barındırır.
            char character = 'A';
            Console.WriteLine("Characterbis : {0}", character);

            // double: ondalıklı değerleri tutar.
            double number5 = 10.5;  
            Console.WriteLine("Number5 is {0}", number5);

            // decimal: virgülden sonra daha fazla(double göre) basamak barındırır.
            decimal number6 = 10.5m;
            Console.WriteLine("Number6 is {0}", number6);

            // var: hangi değer yazılırsa var tipi o değerin türüyle eşlenir.
            var number7 = 200;
            
            Console.WriteLine(Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);

            Console.ReadLine();
        }

        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}