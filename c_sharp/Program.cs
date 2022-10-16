// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static System.Console;
WriteLine("1#");

custom_pow task1_error= new custom_pow(base_num:100000.0,multiply_num:15);//shout
decimal output=task1_error.main();
WriteLine(output);

custom_pow task1_valid= new custom_pow(base_num:2.0,multiply_num:10);//1024
output=task1_valid.main();
WriteLine(output);
custom_pow task1_double= new custom_pow(base_num:9.99,multiply_num:10);//9900448802.097485 =))
//:( Если хочешь плавающую точку то нужно конструировать с оглядкой на это. А деч 
output=task1_double.main();
WriteLine(output);

// bool q;
// q=(Decimal.MaxValue>long.MaxValue);
// WriteLine(q);
WriteLine("2#");
number_poking obj;
string[] exa = new string[]{"123",@"._. человек даже с атрофированной эмпатией остаётся человеком.
Это нужно помнить всегда просто чтобы сопротивляться телевизору, сохранить собственную гуманность."};
foreach (string iter in exa)
{
    obj=new number_poking(iter);
    obj.show_sum_of_digits();

}
WriteLine("3#");
array_randomized task3= new array_randomized(20,-10,10);
WriteLine("Печатаем в пустоту");
task3.print_result();
string imported= task3.return_string();
WriteLine(@$"
Возвращаем строку:
{imported}");