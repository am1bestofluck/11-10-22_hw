import task1,task2,task3

def main():
    iterate={"#1":task1,"#2":task2,"#3":task3}
    for walk in iterate:
        print(f"\n{walk}")
        iterate[walk].main()
if __name__=="__main__":
    main()