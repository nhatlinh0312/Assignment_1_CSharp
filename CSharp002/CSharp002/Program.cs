// See https://aka.ms/new-console-template for more information
Console.WriteLine("hoc ve kieu du lieu cua bien");
// kiểu dữ liệu là phạm vi của giá trị mà một biên lưu trũ
// 1- tìm hiểu về kiều dữ liệu dạng số
// tìm hiểu về kiểu số nguyên và số thực
int number = 10;
Console.WriteLine(number);
Double number2 = 100.321;
Console.WriteLine(number2);
float number3 = 10.1f;
Console.WriteLine(number3);
float number4 = 20.54f;
float number5 = number3 + number4;
Console.WriteLine(number5);

const double PI = 3.14;
number = 50; // chinhs xacs
// PI = 3.15; // loi vi laf hang so khong thay doi gia tri
Console.WriteLine(PI);
double n1 = 17;
double n2 = 9;
Double n3 = n1 / n2;
Console.WriteLine(n3);
// lieu du lieu Boolean
bool checking = true;
bool isValidate = false;
// kieu du ieu ve ky tu
char test = 'C'; // dung nhay don va chi luu tru 1 ky tu don duy nhat

// kieu string - chuoi : dung dau nhay kep de khai bao.
string myStr = "Dang hoc ngon ngu C#";

int myNumber = 10;
double myNumber2 = (double)myNumber;
// chuyen int ve double
Console.WriteLine(myNumber2);
//string myTest = (string)test; // sai vi khong the chuyen tu char sang string

int i = 10;
int j = 9;
//int h = (++i) - (--j) + (i--) - (j++) + (i++) + (++j);
//Console.WriteLine(h);
//  k =   11  -  8    +   11  -   8   +   10  +   10
//Console.WriteLine(k); // 26
//int a = (j++) + (i++) - (--i) - (--j) + (++i) + (--j);
//Console.WriteLine(a);
// ++ đứng trước là tăng thêm 1 giá trị
// -- đứng trước là trừ đi 1 giá trị
// ++ đứng sau ở thơì điểm đo giá trị chưa tăng
// -- đứng sau ở thời điểm đó giá trị chưa giảm

int u = 5;
int t = 6;
int m = (u++) - (--u) + (++t) - (--t) + (u++) - (t--);
//  m =   5   -   4   +   7   -   6   +   4   -   6
Console.WriteLine(m);