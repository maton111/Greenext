import re

def Add(numbers):
    if not numbers or numbers.isspace():
        return 0

    # if ',' not in numbers:
    #     if numbers.isnumeric():
    #         if int(numbers) >= 0:
    #             return int(numbers)
    #     else:
    #         return ValueError("Please check the string and retry.")

    if numbers.startswith("//"):
        delimiter_pattern = r"//(.+?)//"
        delimiter_matches = re.findall(delimiter_pattern, numbers)
        delimiters = re.findall(r"\[(.*?)\]", numbers)

        numbers = numbers.replace("//", '')
        for delimiter_match in delimiter_matches:
            numbers = numbers.replace(delimiter_match, '')

        delimiters = sorted(delimiters, key=len, reverse=True)
        for delimiter in delimiters:
            numbers = numbers.replace(delimiter, 'x')
        numbers = numbers.split('x')
    else:
        numbers = numbers.split(',')

    valid_numbers = []
    for num in numbers:
        num = num.strip()
        if num:
            valid_numbers.append(num)

    for num in valid_numbers:
        if "," not in num and any(char not in "-0123456789" for char in num):
            raise ValueError("Please insert only number separated by comma with normal delimiter.")
        # if " " in numbers and ',' not in numbers:
        #     return ValueError("Please insert comma between the numbers.")

    negatives = [int(num) for num in valid_numbers if int(num) < 0]
    if negatives:
        raise ValueError("Negatives not allowed: " + ", ".join(str(num) for num in negatives))

    filtered_nums = [int(num) for num in valid_numbers if int(num) < 1000]
    return sum(filtered_nums)

def Repeat(bool):
    bool = bool.upper()

    if bool == "Y":
        print("Insert your string of numbers:", end=" ")
        numbers = str(input())

        try:
            print(Add(numbers))
            print()

            print("Do you want to do another sum? (Y or N)")
            print(">", end=" ")
            print(Repeat(str(input())))
            print()
        except ValueError as e:
            print(str(e))
            print()

            print("Do you want to do another sum? (Y or N)")
            print(">", end=" ")
            print(Repeat(str(input())))
            print()

    elif bool == "N":
        print("Thank you and bye.")
        exit()

    else:
        print("Please if you want to do another sum type Y, else type N.")
        print(">", end=" ")
        Repeat(str(input()))
        print()


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print("""
        Write a simple string calculator in python with a method int Add(string numbers).
        This method can take 0, 1 or 2 numbers, separated by commas, and will return their sum, examples: 
        - “” should return 0
        - “1” should return 1
        - “1,2” should return 3
        Moreover, the Add method has to be allowed to handle an unknown amount of numbers.
        Also, calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed.
        If there are multiple negatives, all of them have to be shown in the exception message. Numbers bigger than 1000 should be ignored, for example “1000,2” should return 2. 
        Also add Delimeters of any lenght as “//[delimiter]//” and multiple delimiters must be allowed as in “//[delim1][delim2]//” even longer than one char.
        
    """)
    print("Insert your string of numbers:", end=" ")
    numbers = str(input())

    try:
        print(Add(numbers))
        print()

        print("Do you want to do another sum? (Y or N)")
        print(">", end=" ")
        print(Repeat(str(input())))
        print()
    except ValueError as e:
        print(str(e))
        print()

        print("Do you want to do another sum? (Y or N)")
        print(">", end=" ")
        print(Repeat(str(input())))
        print()
