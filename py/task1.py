# Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
# инит

# делаем функцию которая принимает два инта.. а на выходе дает самое большое что вообще есть. Лонг?

# правка по ходу; лонг целочисленный, будем принимать дробные основания тоже, а выводить десимал.

# Валидация какая?

# Степень целое положительное, основание целое//скууучно XD
# Обработать переполнение
def get_input(invite:str,negative_tolerated=True):
    output=""
    negative_output=False
    while not output.isdecimal():
        output=input(invite)
        if output.startswith("-") and output.count("-")==1:
            if negative_tolerated:
                output=output[1:]
                negative_output=True
            else:
                output="отрицательные величины тут не допускаются"
                print(output)
    return (int(output),negative_output)
def core(base:tuple,pow:tuple)->int:
    supval=-base[0] if base[1]==True else base[0]
    return supval**pow[0]
def main():
    print(core(base=get_input(invite="дай основание плз"),
     pow=get_input( invite="дай степень плз",negative_tolerated=False)))
if __name__=="__main__":
    print("можно вызвать мэйн, но лучше запустить head")