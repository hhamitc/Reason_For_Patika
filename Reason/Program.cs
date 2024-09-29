using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reason
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Hamit";
            string surname = " Canpolat";
            string reason = "Yazılım dünyasına Patika+ ile giriş yapmak istedim çünkü, yalnız başıma denediğimde irademin yetersiz kaldığını ve zorlandığım noktalarda pes etmeye meyilli olduğumu anladım. \nBu süreçte Patika+ ekibinin eğitim kalitesine ve mentörlüğüne, birlikte eğitim aldığım arkadaşlarımın da motivasyonuna güveniyorum. \nBen de beklediğim motivasyonu ekibin geri kalanı için sağlayacağımı vaat ediyorum. Şimdiden teşekkürler. ";

            Console.WriteLine(name + surname);
            Console.WriteLine("-----------------------");
            Console.WriteLine(reason);

            Console.Read();
        }
    }
}
