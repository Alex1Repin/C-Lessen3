﻿//Вид 1
void Method1()
{
    Console.WriteLine("Автор Я");
}
//Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
//Method21("Текст сообщения", 4);
//Method21(count: 4, msg: "Новый текст");

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while(i < count)
    {
        result = result + text;
        i ++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
