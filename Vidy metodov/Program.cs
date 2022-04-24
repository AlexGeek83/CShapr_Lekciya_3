﻿// Вид 1 - НИЧЕГО НЕ ПРИНИМАЕТ И НЕ ВОЗВРАЩАЕТ !!!

void Mothod1() // где void - метод, Method1 - идентификатор,
{
Console.WriteLine("АВТОР ...");
}
// ВЫЗЫВАЮТСЯ ЭТИ МЕТОДЫ ТАК - ВВОДИМ ИДЕНТИФИКАТОР ЭТОГО МЕТОДА И ОБЯЗАТЕЛЬНО КРУГЛЫЕ СКОБКИ:
// Mothod1();

// ==================================================================================

// ВИД 2 -  МЕТОДЫ НИЧЕГО НЕ ВОЗВРАЩАЮТ, НО ПРИНИМАЮТ КАКИЕ ТО АРГУМЕНТЫ
void Method2(string msg) // где void - метод, Method2 - идентификатор, а msg - какое-то количество аргументов
{
    System.Console.WriteLine(msg);
}
// Method2("Текст сообщения");  // вызываем метод
// ---------------------------------------------------------------------------------
// 2- й Вариант применения этого метода, например показать 4 раза сообщение
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст" , 4);
// Порядок не важен, можно и так (см ниже):
// Method21( count: 4, msg: "Новый текст");

//======================================================================================

// Вид 3 - МЕТОДЫ ЧТО-ТО ВОЗВРАЩАЮТ, НО НИЧЕГО НЕ ПРИНИМАЮТ
// Обязательно указываем тип данных

int Method3()
{
    return DateTime.Now.Year;  // текущий год
}
// Вызываем метод

//int year = Method3();
//System.Console.WriteLine(year);

//======================================================================================

// Вид 4 - МЕТОД КОТОРЫЙ ЧТО-ТО ПРИНИМАЕТ И ЧТО-ТО ВОЗВРАЩАЕТ

string Method4(int count, string text) //Возвращать будем строку (в скобках тип данных)
// то есть строку string c будем компоновать count раз
{
    int i = 0;
    string result = String.Empty;  // переменная куда будем класть результат. "" - указывается пустая строка кавычками
    // или String.Empty, то есть result изначально будет пустой строкой

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwery");  // чтобы вызвать нужно указать переменную
System.Console.WriteLine(res); // выводим на экран