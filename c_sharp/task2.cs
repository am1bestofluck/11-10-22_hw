// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Приглашение ко вводу
// Валидация;
// Приводим к абс
// Дробим на знаки//вывести в класс
// Складываем
// вывод
using static System.Console;
class number_poking
{
    int client;
    string incoming_string;
    public number_poking(string number_ext)
    {
        this.client=validate_input(number_i:number_ext);
    }
    //валидация
    private dynamic validate_input(string number_i)
    {
        bool is_input_valid=false;
        while (is_input_valid==false)
        {
            is_input_valid=Int32.TryParse(number_i,out client);
            if (is_input_valid==false)
            {
                WriteLine($"Строку '{number_i}' перечитать как целое число не получилось. Попробуй ещё раз?");
                number_i=ReadLine();
            }

        }
        return client;
    }
    //ядро
    public dynamic show_sum_of_digits()
    {
        int show_this=0,supval=this.client;
        while (supval>0)
        {
            show_this+=supval%10;
            supval/=10;
        }
        WriteLine($"Сумма цифр в числе {this.client}: {show_this}");
        return null;
    }
}