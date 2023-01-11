namespace bai7
{
    class Program
    {
        //Bai 1:
        //Nhập số ngày kinh doanh của một cửa hàng và tên, giá cả từng mặt hàng hôm đó. 
        //In ra ngày có doanh thu cao nhất và doanh thu thấp nhất.
        struct MatHang
        {
            public string ten;
            public int gia;
        }
        struct DoanhSo
        {
            public int tongDThu;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so ngay ban hang: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            MatHang[][] matHang = new MatHang[a][];
            DoanhSo[] ds = new DoanhSo[a];

            for(int i = 0; i < a; i++)
            {
                Console.Write("So don hang ban duoc ngay thu " + (i + 1) + ": ");
                int b = Convert.ToInt32(Console.ReadLine());
                MatHang[] mh = new MatHang[b];
                for (int j = 0; j < b; j++)
                {
                    matHang[i] = new MatHang[b];
                    Console.Write("Ten don hang thu " + (j + 1) + ": ");
                    matHang[i][j].ten = Console.ReadLine();
                    Console.Write("Gia don hang thu " + (j + 1) + ": ");
                    matHang[i][j].gia = Convert.ToInt32(Console.ReadLine());
                    ds[i].tongDThu += matHang[i][j].gia;
                }
            }
            int max = 0, ngayMax = 0, min = 0, ngayMin = 0;
            for(int i = 0; i < ds.Length; i++)
            {
                if (i == 0)
                {
                    min = ds[i].tongDThu;
                    ngayMin = (i + 1);
                }
                if (ds[i].tongDThu > max)
                {
                    max = ds[i].tongDThu;
                    ngayMax = i +1;
                }
                if (ds[i].tongDThu < min)
                {
                    min = ds[i].tongDThu;
                    ngayMin = (i + 1);
                }
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Ngay thu {0} co doanh thu cao nhat thu duoc {1} dong"  , ngayMax , max );
            Console.WriteLine("Ngay thu {0} co doanh thu thap nhat thu duoc {1} dong" , ngayMin , min);
        }
    }
}
