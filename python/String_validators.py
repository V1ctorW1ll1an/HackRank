if __name__ == '__main__':
    s = input()
    print(any(string.isalnum() for string in s))
    print(any(string.isalpha() for string in s))
    print(any(string.isdigit() for string in s))
    print(any(string.islower() for string in s))
    print(any(string.isupper() for string in s))
