﻿// See https://aka.ms/new-console-template for more information
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
// // q=(Decimal.MaxValue>long.MaxValue);
// WriteLine(q);