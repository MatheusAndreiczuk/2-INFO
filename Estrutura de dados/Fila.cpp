#include <stdio.h>
#include <malloc.h>
#include <stdlib.h>
#define MAX 5
struct fila {
	int n;
	int ini,fim;
	float vet[5];
	// muda aqui o tipo de dado que aceita
};
typedef struct fila Fila;
Fila* cria (void){
	// devolve um ponteiro para fila como resultado
	Fila* f=(Fila*) malloc (sizeof(Fila));
	// declarando um ponteiro para fila chamado f
	f-> ini= f->fim=0;
	// inicializando as 2 vari�veis, fim e ini .
	return f;
	//devolve o ponteiro de fila
}
int incr(int i){
	// incrementar ou passar para a pr�xima posi��o livre o vetor
	if (i==99)
	// se tivesse um vetor menor teria que mudar aqui. EX.: vet[50] ----- if(i==49)
	return 0;
	else
	return i+1;
}
void insere(Fila* f,float v){
	// diz o valor que vai inserir, sempre inmserido no final da fila
	if (incr(f->fim)== f->ini){
		// verifica se a fila est� com a capacidade m�xima
	printf("Capacidade da fila estourou!!!\n");
		exit(1);
		// sai do programa
}
	f->vet[f->fim]=v;
	// no vetor e na posi��o do fim ele vai colocar o elemento que vc quer inserir
	f->fim=incr (f->fim);
}
		float retira (Fila* f)
	{
		float v;
		if (f->ini == f->fim)
	{
		printf("Fila vazia!!!\n");
		exit(1);
	}
		v=f->vet[f->ini];
		f->ini = incr(f->ini);
		return v;
}
void mostrafila(Fila *f)
{
    int v=f->ini;
    printf("\nTOPO ->");
    while (v!= f->fim)
    {
        printf("%d -> %f\n", v, f->vet[v]);
        v = incr(v);
    }
    printf("Fim\n");
}
void libera (Fila* f)
{
free(f);
}
int main()
{
Fila* f=cria();
float elem;
int opcao=0;
while (opcao!=4)
{
printf("\n1-Insere na fila\n2-Retira da fila\n3-Mostra fila\n4-Fim\n");
printf("Selecione sua op��o (1-4)");
scanf("%d",&opcao);
switch(opcao){
case 1: printf("Digite o elemento a inserir");
scanf("%f",&elem);
insere(f,elem);
break;
case 2: printf("Elemento retirado: %f",retira(f));
break;
case 3: mostrafila(f); break;
case 4: break;
default: printf("Op��o inv�lida");
}
}
libera(f);
}
