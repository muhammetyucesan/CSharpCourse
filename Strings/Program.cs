using static System.Net.Mime.MediaTypeNames;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Muhammet Yücesan";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            // klonla ve yeni bir referans oluştur.

            sentence = "My name is Kadriye Yücesan";
            Console.WriteLine(result); 
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("n");
            // metnin ilgili harfle bitip bitmediğine bak. True or False

            bool result4 = sentence.StartsWith("My name");
            // metnin ilgili harfle başlayıp başlamadığına bak. True or False

            var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);
            // indexi gösterir

            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6);
            //ilk boşluğun indexini verir

            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);
            //index aramaya tersten başlar bulduğu noktanın baştan kaçıncı indexinde olduğunu gösterir.

            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8); 
            //başka bir ifade eklemek için kullanılır.
            // Hello, My name is Kadriye Yücesan

            var result9 = sentence.Substring(3, 4); // çıkarmak için kullanılır.
            Console.WriteLine(result9);
            // name

            var result10 = sentence.ToLower(); //tüm karakterleri küçük harfe çevirir.
            Console.WriteLine(result10);
            // my name is kadriye yücesan

            var result11 = sentence.ToUpper(); //tüm karakterleri büyük harfe çevirir.
            Console.WriteLine(result11);
            // MY NAME IS KADRİYE YÜCESAN

            var result12 = sentence.Replace(" ", "-"); // karakerleri değiştirmek için.
            Console.WriteLine(result12);
            // My-name-is-Kadriye-Yücesan

            var result13 = sentence.Remove(11, 7); //belli bir indexten sonrasını atmak için.
            Console.WriteLine(result13);
            // My name is Yücesan
            //Intro();  Intro yu çağırıyoruz main e.
        }

        private static void Intro()
        {
            string city = "İzmir";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);
            //yan yana yaz
            Console.WriteLine(String.Format("{0} {1}", city, city2));


        }

    }


}