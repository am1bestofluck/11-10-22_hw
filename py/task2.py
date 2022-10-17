# Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
# Приглашение ко вводу
# Валидация;
# Приводим к абс
# Дробим на знаки//вывести в класс
# Складываем
# вывод
from task1 import get_input
def core(inc_val:set):
    output=0
    supval=inc_val[0]
    while supval>0:
        output+=supval%10
        supval=supval//10
    return output
    
def main():
    _client=get_input("дай число на суммирование знаков пож")
    print(core(inc_val=_client))
if __name__=="__main__":
    print("можно вызвать мэйн, но лучше запустить head")