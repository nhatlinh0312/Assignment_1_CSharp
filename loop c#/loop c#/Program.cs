// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Biểu diễn một vongf lặp : duyệt qua các số từ 1 đến 10
// điểm bắt đầu của vòng lặp là như thế nào 
// điểm kết thúc của vòng lặp là như thế nào 
// sau khi mỗi vòng lặp kết thúc thì vòng lặp tiếp theo se được diễn ra như thế nào
int sum = 0;
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    sum += i;
}
Console.WriteLine(sum);
// dung vong lap for...
// dung vong lap while
// vong lap while: vong lap kiem tra dieu kien truoc
int j = 1;
while(j <= 10)
{
    Console.WriteLine(j);
    j++;
}

int k = 1;
do
{
    Console.WriteLine(k);
    k++;
}while(k <= 10);
// su dung vong lap while tinh tong cac so chan tu 1 den 30;

int l = 1;
int r = 1;
while(r <= 30)
{
    if (r % 2 == 0)
    {
        l += r;
    }
    r++;
}
Console.WriteLine(l);
// su dung vong lap do... while: dem xem co bao nhieu so le tu 1 den 30?

int sole = 0;
int a = 1;
do
{
    if (a % 2 != 0)
    {
        sole++;
    }
    a++;
}
while (a <= 30);
Console.WriteLine(sole);

for (int m = 1; m <= 10; m++)
{
    Console.WriteLine(m);
    if (m % 5 == 0)
    {
        break; // dung va thoat vong lap
    }
}
for (int m = 1; m<=10; m++)
{
    if(m < 6)
    {
        Console.WriteLine(m);
        continue;
    }
    Console.WriteLine(m);
}