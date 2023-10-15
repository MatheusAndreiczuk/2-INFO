#include <stdio.h>
int v[10];
void countingSort(int v[], int n){
int aux[10];
int k[10];
int j = 0;
  
for(int i = 1; i < n; i++){
    if (v[i] > j)
    j = v[i];
}

for(int i = 0; i <= j; ++i){
    k[i] = 0;
}

for(int i = 0; i < n; i++){
    k[v[i]]++;
}

for(int i = 1; i <= j; i++){
    k[i] += k[i - 1];
}

for(int i = n - 1; i >= 0; i--){
    aux[k[v[i]] - 1] = v[i];
    k[v[i]]--;
}

for(int i = 0; i < n; i++){
    v[i] = aux[i];
}
}

int main() {
int i = 0;
int n = sizeof(v) / sizeof(v[0]);
for (i = 0; i < 10; i++){
	printf("Digite o valor");
	scanf("%d", &v[i]);
}
countingSort(v, n);
for (i = 0; i < 10; i++){
	printf("%d\n", v[i]);
}
}


