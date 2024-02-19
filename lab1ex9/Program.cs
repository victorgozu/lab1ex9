/*
 * Ex 9
Scrieti un program care interschimba valoarea a doua variabile intregi.
*/

Console.WriteLine("Introduceti primul numar intreg:");
int numar1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar intreg:");
int numar2 = int.Parse(Console.ReadLine());

int numarTemp = numar2;
numar2 = numar1;
numar1 = numarTemp;

Console.WriteLine("Primul numar devine " + numar1 + ", iar cel de-al al doilea devine " + numar2);