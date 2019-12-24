using System.Threading;
using System.Windows.Forms;

namespace System.Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] character = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "k", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", ".", ",", "!", "?", "/", "%", "#" };

            Random random = new Random();
            int lenght = 16;
            int ab = 0;

            string generated = "";
            while (ab != lenght)
            {
                ab = ab + 1;
                generated = generated.Insert(
                    random.Next(generated.Length),
                    character[random.Next(character.Length)].ToString()
                );
            }
            

            var t = new Thread((ThreadStart)(() =>

            {

                Clipboard.SetText(generated);

            }));

            t.SetApartmentState(ApartmentState.STA);

            t.Start();

            t.Join();

            return;
        }
    }
}
