#!/bin/python3

def diagonalDifference(arr):
    # Write your code here
    left = []
    right = []
    for i in range(len(arr)):
        right.append(arr[i][i])
        left.append(arr[i][len(arr) - i - 1])
    return abs(sum(right) - sum(left))


if __name__ == '__main__':
    n = int(input().strip())
    arr = []
    for _ in range(n):
        arr.append(list(map(int, input().rstrip().split())))

    result = diagonalDifference(arr)
    print(result)
