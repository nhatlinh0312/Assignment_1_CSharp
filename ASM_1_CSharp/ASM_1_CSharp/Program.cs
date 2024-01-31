// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********** chuong trinh tinh hoa don tien dien nuoc***********");

void TinhTienHoaDonNuoc()
{
    Console.WriteLine("Nhap ho ten khach hang: ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("vui long chon loai khach hang");
    Console.WriteLine("nhap so 1 neu ban la khach hang ho gia dinh");
    Console.WriteLine("nhap so 2 neu ban la loai khach hang co quan hanh chinh");
    Console.WriteLine("nhap so 3 neu ban la loai khach hang don vi san xuat");
    Console.WriteLine("nhap so 4 neu ban la loai khach hang dich vu kinh doanh");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // khach hang ho gia dinh
        // yeu cau nhap so luong thanh vien trong gia dinh
        Console.WriteLine("nhap so luong thanh vien trong gia dinh");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember > 1)
        {
            Console.WriteLine("nhap chi so nuoc cua thang truoc");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chi so dong nuoc cua thang nay");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                Double waterNumberPeople = waterNumber / numberMember;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumber <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("Tien nuoc cua gia dinh ban la:{0}", money);
            }
            else
            {
                Console.WriteLine("So nuoc cua thang truoc khong lon hon so nuoc cua thang hien tai");
            }
        }
        else
        {
            Console.WriteLine("ban khong phai khach hang ho gia dinh");
        }
    }
    else if (typeCustomer == 2)
    {
        // khach hang co quan hanh chinh cong
        Console.WriteLine("vui long nhap chi so dong ho nuoc thang truoc");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("vui long nhap chi so dong ho nuoc thang hien tai");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("tien nuoc cua co quan hanh chinh cong la {0}", m);
        }
        else
        {
            Console.WriteLine("chi so dong ho nuoc thang truoc khong lon hon cua thang hien tai");
        }
    }
    else if (typeCustomer == 3)
    {
        // khach hang don vi san xuat
        Console.WriteLine("vui long nhap chi so dong ho nuoc thang truoc");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("vui long nhap chi so dong ho nuoc thang hien tai");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double n = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine("tien nuoc cua don vi san xuat la {0}", n);
        }
        else
        {
            Console.WriteLine("chi so dong ho nuoc thang truoc khong lon hon cua thang hien tai"); 
        }
    }
    else if (typeCustomer == 4)
    {
        // khach hang kinh doanh
        Console.WriteLine("vui long nhap chi so dong ho nuoc thang truoc");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("vui long nhap chi so dong ho nuoc thang hien tai");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double a = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine("tien nuoc cua don vi kinh doanh la {0}", a);
        }
        else
        {
            Console.WriteLine("chi so dong ho nuoc thang truoc khong lon hon cua thang hien tai");
        }

    }
    else
    {
        Console.WriteLine("Vui long nhap dung the loai khach hang");
    }
}
//chay truong trinh
TinhTienHoaDonNuoc();
