#include <malloc.h>
#include <stdlib.h>
#include <stdio.h>
#define MAX 50
// cria uma constante ( m�ximo de elementos que pode ser enpilhaodos = 50 )
struct pilha
// estrutura pilha {
int n;
// quantidades de elementos
char vet[MAX];
// aqui mudamos o tipo de dados que aceita
// vetor com o m�ximo de elementos que pode ser empilhados
};
typedef struct pilha Pilha;
// renomeando estrutura pilha
Pilha* cria (void)
// cria uma pilha
{
Pilha* p = (Pilha*) malloc(sizeof(Pilha));
// ponteiro de pilha
p->n = 0;
// inicialmente o n ( quantidade de lementos ) � 0
return p;
}
// essa fun��o devolve um ponteiro de pilha
void push (Pilha* p, char v)
// empilhar 
// passamos o ponteiro com o valor que desejamos empilhar
{
if (p->n == MAX)
// verificando se pn � igual ao max ( se a quantidade de elementos for 50 ) {
printf("Erro de estouro de pilha.\n");
// sai do programa apos dar o erro
exit(1);
}
p->vet[p->n] = v;
// colocando o elemento na pr�xima posi��o livre
// pn � a quantidade de elementos da pilha
p->n++;
// conforme inserimos aumenta o pn que � a quantidade de elementos
}
float pop (Pilha* p)
// de qual pilha eu quero tirar o elemento
// fun��o desempilha
{
char v;
// se fosse de outro tipo trocamos aqui tamb�m
if (p->n==0)
// se a pilha for vazia
{
printf("Erro de esvaziamento de pilha.\n");
exit(1);
// fecha o frograma
}
v = p->vet[p->n-1];
// como foi retirado um elemento, o primeiro elemento desce uma casa
// int topo = [p->n - 1]
p->n--;
// reduz em 1 o elemento de pn, que � quantidade de elementos que tem
return v;
}
void libera (Pilha* p)
{
free(p);
// libera o espa�o na memoria que esta sendo utilizado nessa estrutura
}
void mostrapilha(Pilha* p)
// mostra todos os elementos
{
char n=p->n-1;
// n recebe pn -1, que � a posi��o do topo
while(n>=0)
// enquanto n for igual ou maior que 0 {
if(n==p->n-1)
// verifica se n � igual ao pn -1
printf("TOPO ->");
// mostra um float e pula linha, mostra o elemento que esta na posi��o n, que � o ultimo elemento nesse caso
// mostra o topo
else
printf(" ->");
printf("%c\n",p->vet[n]);
// mostra um float e pula linha, mostra o elemento que esta na posi��o n, que � o ultimo elemento nesse caso
n--;
// passa para o proximo elemento
}
}
int main()
{
Pilha* p=cria();
// 
float elem;
int opcao=-1;
while(opcao!=4){
	printf("1-Empilha\n2-Desempilha\n3-Mostra pilha\n4-Sair\n");
printf("Digite a op��o (1-4)");
scanf("%d",&opcao);
switch(opcao){
case 1: printf("Digite o elemento a empilhar ");
scanf("%f",&elem);
push(p,elem);
break;
case 2: printf("Elemento desempilhado %c\n",pop(p));
break;
case 3: mostrapilha(p); break;
case 4: break;
default: printf("Op��o inv�lida\n");
}
}
libera(p);
}
