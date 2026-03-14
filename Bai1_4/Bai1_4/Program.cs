namespace  Bai1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0;
            int chan = 0, le = 0;
            Boolean check = true;
            Console.Write("n = "); n = Convert.ToInt32(Console.ReadLine());
            
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // In
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[j] + " ");
            }
            
            // Tim so lon nhat
            for (int k = 0; k < n; k++)
            {
                if (a[k] > x)
                {
                    x = a[k];
                }
            }
            Console.Write("| So lon nhat la: " + x);
            
            //Kiem tra mang duoc sap xep tang dan
            for (int q = 0; q < n; q++)
            {
                if (a[q + 1] < a[q])
                {
                    check = false;
                    break;
                }
            }
            Console.Write(" | " + check);
            
            //Sapxep 
            for (int f = 0; f < n; f++)
            {
                int save1 = 0;
                for (int g = 0; g < n; g++)
                {
                    if (a[f] < a[g])
                    {
                        save1 = a[f];
                        a[f] = a[g];
                        a[g] = save1;
                    }
                }
            }
            Console.Write(" | Mang sau khi sap xep: ");
            for (int h = 0; h < n; h++)
            {
                Console.Write(a[h] + " ");
            }
            
            //tachmang
            for (int l = 0; l < n; l++)
            {
                if (a[l] % 2 == 0)
                {
                    chan++;
                    b[chan] = a[l];
                }
                else
                {
                    le++;
                    c[le] = a[l];
                }
            }
            
            Console.Write(" | Mang chan: ");
            for (int v = 1; v <= chan; v++)
            {
                Console.Write(b[v] + " ");
            }
            
            Console.Write(" | Mang le: ");
            for (int m = 1; m <= le; m++)
            {
                Console.Write(c[m] + " ");
            }
        }
    }
}