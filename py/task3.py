# Напишите программу, которая задаёт массив из N 3лементов и выводит их на экран.
import random
from task1 import get_input
def core(size:tuple,lower_limit:tuple,upper_limit:tuple)->str:
    supval_out=[]
    supval_l=lower_limit[0]*-1 if lower_limit[1]==True else lower_limit[0]
    supval_u=upper_limit[0]*-1 if upper_limit[1]==True else upper_limit[0]
    if supval_u==supval_l:
        supval_u=supval_l+1
        # print("l")
    for i in range(size[0]):
        supval_out.append(random.choice(
            range(min(supval_u,supval_l),
        max(supval_u,supval_l))))
    return str(supval_out)
def main():
    print(core(size=get_input("дай размер массива плз",False),
    lower_limit=get_input("дай нижний предел выборки плз"),
    upper_limit=get_input("дай верхний предел выборки плз")))
    return
if __name__=="__main__":
    print("можно вызвать мэйн, но лучше запустить head")
    main()