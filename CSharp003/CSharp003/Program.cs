// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Security.Cryptography;

//Console.WriteLine("xu ly cac menh de dieu khien trong C#");
/*
 * viet chuong trinh kiem tra 1 so nhap tu ban phim la
 * so chan hay la so le
 * */
//Console.WriteLine("Moi nhap so de kiem tra: ");
//int number = Convert.ToInt32(Console.ReadLine());
// chuyen doi kieu du kieu tu str ve int
// vi moi gia tri nhap tu thiet bi ngoai vi ( ban phim) thi kieu du lieu luon luon mac dinh la string
// Convert.ToInt32 : chuyen ve so nguyen 32 bit

// lam the nao kiem tra so so chan hay le
// thuat toan : chia cho 2 kiem tra so du
//if (number % 2 == 0) 
//{
//    Console.WriteLine("{0} la so chan", number);
//}
//else
//{
//    Console.WriteLine("{0} la so le", number);
//}
Console.WriteLine("Moi nhap nam de kiem tra: ");
int year = Convert.ToInt32(Console.ReadLine());
int mod4 = year % 4;
int mod100 = year % 100;
int mod400 = year % 400;
if (mod4 == 0 && mod100 != 0)
{
    Console.WriteLine("{0} la nam nhuan", year);
}
else if(mod400 == 0)
{
    Console.WriteLine("{0} la nam nhuan", year);
}
else
{
    Console.WriteLine("{0} khong la nam nhuan", year);
}

// cau truc dieu khien swich ... case
// nhap vao 1 thang kiem tra thang do cos bao nhieu ngay

int month = 1;
if (month == 1)
{
    // thong bao ket qua
}
else if (month == 2)
{
    // thong bao ket qua
}
else if (month == 2)
{
    // thong bao ket qua
}
else
{
    // thong bao ket qua
}
// if ... else long nhau( cac dieu kien kiem tra long nhau)
// cau truc dieu khien swich ... case

Console.WriteLine("Moi nhap thang:");
switch(month)
{
    case 1: // so sanh month co bang 1 ?
        // thong bao ket qua
        Console.WriteLine(" 31 days");
        break;
    case 2:  // so sanh month co bang 2 ?
        // thong bao ket qua
        Console.WriteLine(" 28 days");
        break;
    case 3:
        // thong bao ket qua
        Console.WriteLine(" 31 days");
        break;
    default:
        // thong bao ket qua
        Console.WriteLine(" Month invalid");
        break;
}

// su dung if ... else viet chuong trinh kiem tra do dai ba canh co phai la do dai cua tam giac hay khong

Console.WriteLine("Nhap do dai canh a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nhap do dai canh b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nhap do dai canh c:");
double c = Convert.ToInt32(Console.ReadLine()); 
if ( a+b > c && b+c > a && a+c > b && a > Math.Abs(b-c) && b > Math.Abs(a-c) && c > Math.Abs(b-a))
{
    Console.WriteLine("Hop le");
}
else
{
    Console.WriteLine("khong hop le");
}

