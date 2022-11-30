using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Binary
{
    /// <summary>
    /// Interaktionslogik für binary2decimal.xaml
    /// </summary>
    public partial class binary2decimal : Window
    {
        long[] byteNums = new long[]
        {
            1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 
            536870912, 1073741824, 2147483648, 4294967296, 8589934592, 1719869184, 34359738368, 68719476736, 137438953472, 274877906944, 549755813888, 1099511627776, 2199023255552, 4398046511104, 8796093022208, 
            17592186044416, 35184372088832, 70368744177664, 140737488355328, 281474976710656, 562949953421312, 1125899906842624
        };

        public binary2decimal(string binary)
        {
            InitializeComponent();
            //long l = long.Parse(binary);
            long b = byteNums[byteNums.Length - 1];
            for (int i = 0; i < 30; i++)
            {
                b = b * 2;
                Console.WriteLine(b);
            }
            Console.WriteLine("genDecimalNum");
            long ges = 0;
            if (binary.Length <= 50)
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    string s = binary.Substring(i, 1);
                    Console.WriteLine(s);
                    if (s == "1")
                    {
                        ges += byteNums[binary.Length - i];
                    }
                }
                TB_deciaml.Text = (ges / 2).ToString();
            }
            else
            {
                Console.WriteLine("Test gescheitert");
            }
            Console.WriteLine("gesNums");
            //1048575
            long k = 0;
            for (int i = 0; i < byteNums.Length; i++)
            {
                k += byteNums[i];
                Console.WriteLine(k);
            }
        }
    }
}
