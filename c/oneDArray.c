#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {

    /* Enter your code here. Read input from STDIN. Print output to STDOUT */    
    int n = 0, sum = 0;
    int *arr;
    
    scanf("%d", &n);
    arr = (int*)malloc(n * sizeof(int));
    
    for (int i=0; i < n; i++) {
        scanf("%d", &arr[i]);
        sum += arr[i];
    }
    
    printf("%d\n", sum);
    free(arr);
   
    return 0;
}
