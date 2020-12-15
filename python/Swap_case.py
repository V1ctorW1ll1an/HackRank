def swap_case(s):
    l = []
    for i in range(0, len(s)):
        l.append(s[i].lower() if s[i].isupper() else s[i].upper())
    return "".join(l)


if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)
