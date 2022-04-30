using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzPiletsky
{
    public class Input
    {
        public void input(MainWindow MW)
        {
            MW.masTextBox.Clear();
            int N;
            N = Convert.ToInt32(MW.nTextBox.Text);

            int[] mas = new int[N];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 100);
                MW.masTextBox.Text += mas[i] + " ";
            }

            int min;
            int max;
            max = mas[0];
            min = mas[0];

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    MW.maxTextBox.Text = (i + 1).ToString();
                }

                if (mas[i] < min)
                {
                    min = mas[i];
                    MW.minTextBox.Text = (i + 1).ToString();
                }
            }
        }

        public int ResultTest(int x)
        {
            int[] mas = new int[x];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(4, 4);
                x = mas[i];
            }
            return x;
        }
    }
}
