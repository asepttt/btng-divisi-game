// See https://aka.ms/new-console-template for more information
/*
//Operator Aritmatika
var penjumlahan = 10 + 5;
var pengurangan = 10 - 5;
var perkalian = 10 * 5;
var pembagian = 10 / 5;
var notasi = 10 % 5;
Console.WriteLine(penjumlahan);
Console.WriteLine(pengurangan);
Console.WriteLine(perkalian);
Console.WriteLine(pembagian);
Console.WriteLine(notasi);
*/
/*
//Operator Penugasan
int a = 10;
Console.WriteLine(a += 5);
Console.WriteLine(a -= 5);
Console.WriteLine(a *= 5);
Console.WriteLine(a /= 5);
Console.WriteLine(a %= 5);
*/
/*
//Increment dan Decrement
int a = 10;
Console.WriteLine("hasil +a=" + +a);
Console.WriteLine("hasil ++a=" + ++a);
Console.WriteLine("hasil a++=" + a++);

Console.WriteLine("hasil -a=" + -a);
Console.WriteLine("hasil --a=" + --a);
Console.WriteLine("hasil a--=" + a--);
*/
/*
//Operator Perbandingan
int a = 10;
Console.WriteLine(a==10);
Console.WriteLine(a!=10);
Console.WriteLine(a>=10);
Console.WriteLine(a<=10);
Console.WriteLine(a>10);
Console.WriteLine(a<10);
*/
/*
//Array
string[]nama = {"ahmad", "joko", "saep"};
Console.WriteLine(nama[0]);
Console.WriteLine(nama[1]);
Console.WriteLine(nama[2]);
*/
/*
//Array 2D
int[,]number = {{1,2,3}, {4,5,6}};
Console.WriteLine(number[0,1]);
Console.WriteLine(number[1,2]);
*/
/*
//Array 3D
int[,,]numbers = {{{1,2,3}, {4,5,6}}, {{7,8,9}, {10,11,12}}};
Console.WriteLine(numbers[0,0,0]);
Console.WriteLine(numbers[1,1,0]);
*/
/*
//List
var name = new List<string> {"game", "mobile", "web"};
for (int i = 0; i < name.Count; i++)
{
    Console.WriteLine(name[i] + "");
}
*/
/*
//If Else
int a = 10;
if (a==10)
{
    Console.WriteLine("angka sama");
}
else
{
    Console.WriteLine("angka tidak sama");
}
*/
/*
//Ternary
string b = (10 == 10) ? "angka sama" : "angka tidak sama";
Console.WriteLine(b);
*/
/*
//Switch Case
int c = 15;
switch(c)
{
    case 15:
    Console.WriteLine("nilai sama");
    break;
    default:
    Console.WriteLine("nilai tidak sama");
    break;
}
*/
/*
//Perulangan For
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Perulangan ke " + i);
}
*/
/*
//Perulangan While
int i = 0;
while (i < 5)
{
    Console.WriteLine("perulangan ke " + i);
    i++;
}
*/
/*
//Perulangan Do While
int i = 5;
do
{
    Console.WriteLine("Perulangan ke " + i);
    i++;
}while (i < 5);
*/
/*
//Perulangan Foreach
int i = 0;
int[] angka = new int[5] {1, 2, 3, 4, 5 };
foreach (int a in angka)
{
    Console.WriteLine("Ini adalah isi array urut dari indeks ke " + i++ + " yaitu " + a);
}
*/
/*
//Break
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("perulangan ke " + i);
    if(i == 5)
    {
        break;
    }
}
*/
/*
//Continue
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        // Mengabaikan angka genap dan melanjutkan ke iterasi berikutnya
        continue;
    }
    Console.WriteLine(i);
}
*/