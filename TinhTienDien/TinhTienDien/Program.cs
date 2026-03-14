using  System;  
namespace TinhTienDien
{
    class Program
    {
        const int Muc1 = 100, Muc2 = 150, Muc3 = 300;
        const int Gia1 = 2000, Gia2 = 2500, Gia3 = 3000;
        
        static void Main(string[] args)
        {           
            int sokWh = 0;
            int sotien = 0;
            
            Console.Write("Vui long nhap so kwh: ");
            sokWh = Convert.ToInt32(System.Console.ReadLine());

            if (sokWh <= Muc1)
            {
                sotien = sokWh * Gia1;
            } else if (sokWh <= Muc2)
            {
                sotien = 100*Gia1 + (sokWh-100)*Gia2;
            } else if (sokWh <= Muc3)
            {
                sotien = 100*Gia1 + 50*Gia2 + (sokWh-150)*Gia3;
            }
            else
            {
                sotien = 100*Gia1 + 50*Gia2 + (sokWh-150)*Gia3;
                sotien += sotien / 100 * 10;
            }
            
            Console.Write(sotien);
        }
    }
}