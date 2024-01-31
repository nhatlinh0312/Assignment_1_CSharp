// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tim hieu ve funcyion");
// cu phap khai bao function(ham) nhu sau:
// tu khoa khai bao kieu du lieu  tra ve + ten ham
// dinh nghia ham tinh tong 2 so nguyen

int TongHaiSoNguyen(int number1, int number2)
{
    return number1 + number2;
}
// int: kieu du lieu tra ve cua ham
// TongHaiSoNguyen: ten ham
// int number1, int number2: tham so truyen vao ham
// return: tra ket qua ve cho ham(thoat khoi ham luon)
// Goi ham ra su dung

Console.WriteLine("Nhap so thu nhat: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so thu hai: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum = TongHaiSoNguyen(n, m);
Console.WriteLine("Tong hai so {0} va {1} la {2}",n ,m,sum);


void showMessage(string name)
{
    Console.WriteLine("Hello you {0}", name);
}
// tu khoa void : ham ko can co tu khoa return tra ket qua ve
// ham khong can tham so truyen vao
showMessage("Nguyen Nhat Linh");
// viet ham kiem tra 1 so nhap tu ban phim la chan hay le
bool CheckingOddEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
        // gap tu khoa return se thoat khoi ham va khong thuc thi cac lenh ben duoi
    }
    return false;
}
Console.WriteLine("Moi nhap so de kiem tra: ");
int b = Convert.ToInt32(Console.ReadLine());
bool res = CheckingOddEven((int)b);
if (res)
{
    Console.WriteLine("{0} la so chan", b);
}
else
{
    Console.WriteLine("{0} la so le", b);
}
// viet ham kiem tra xem 1 na duong lich la nam nhuan hay khong?
bool CheckingYear(int year)
{
     if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
    {
        return true;
    }
     return false;
}
Console.WriteLine("Moi nhap nam DL de kiem tra: ");
int year = Convert.ToInt32(Console.ReadLine());
bool check = CheckingYear((int)year);
if (check)
{
    Console.WriteLine("{0} la nam nhuan", year);
}
else
{
    Console.WriteLine("{0} khong la nam nhuan", year);
}

