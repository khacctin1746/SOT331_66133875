namespace vitrung
{
	class vitrung
	{
		public static void Main(string[] args)
		{
			int soluong;
			int gio; 
			
			Console.Write("Vui long nhap so luong vi trung: ");
			soluong = Convert.ToInt32(Console.ReadLine());
			Console.Write("Vui long nhap so gio: ");
			gio = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < gio; i++)
			{
				int save;
				save = soluong * 2;
				soluong = save;
			}
			Console.WriteLine(soluong);
		}
	}
}