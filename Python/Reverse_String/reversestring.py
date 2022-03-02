givenStr = input('Enter the string you wish to reverse: ')

length = len(givenStr) -1 

for i in range(length, -1, -1):
    print(givenStr[i],end="")