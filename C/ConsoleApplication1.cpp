
#include <stdio.h>
#include <conio.h>
#include <cstdlib>



int res_size = 1;

typedef struct _Node {// Структура "Узел" для двусвязного списка
    int value;
    struct _Node* next;// указатель на следующий элемент
    struct _Node* prev;// указатель на предыдущий элемент
}_Node;



typedef struct _DblLinkedList { // структура "Двусвязный список"
    int size;// переменная, которая хранит кол-во узлов(размер списка)
    _Node* head;// Указатель на первый элемент списка
    _Node* tail;// указатель на предыдущий элемент списка
}DblLinkedList;


DblLinkedList* createList() { // создание двусвзяного списка
    DblLinkedList* tmp = (DblLinkedList*)malloc(sizeof(DblLinkedList)); // выделение памяти
    tmp->size = 1; // присваиваем полям дефолтные значения
    tmp->head = NULL;
    tmp->tail = NULL;
    return tmp;// возврат указателя на список
}


void pushList(DblLinkedList* list, int n) {// добавление элемента в список

    _Node* tmp = (_Node*)malloc(sizeof(_Node));// выделяем память под новый узел
    if (tmp == NULL) exit(1);// если память не выделилась - выйти из программы
    tmp->value = n;
    tmp->next = list->head; // теперь указатель на след элемент будет голова списка
    tmp->prev = NULL;

    if (list->head) list->head->prev = tmp; // если голова существовала то теперь её ук-ль prev будет указывать на только что созданный элемент

    if (list->tail == NULL) list->tail = tmp; // если "хвоста" не существовало до создания узла, то присваиваем указатель на tail - tmp

    list->head = tmp;// теперь "голова" - новый созданный элемент
}

void printDblLinkedList(DblLinkedList* list) {// печатаем список
    _Node* tmp = list->head; //первый элемент списка
    while (tmp) { //пока tmp != NULL, т.е. указатель существует, выписываем
        printf("%d", tmp->value);
        tmp = tmp->next;// смещаем указатель на следующий элемент
    }
}


DblLinkedList* list = createList();

int multiply(int x) {
    int carry = 0;

    _Node* tmp = list->tail;

    int size = res_size;
    for (int i = 0; i < size; i++) {

        int prod = tmp->value * x + carry;

        tmp->value = prod % 10;

        carry = prod / 10;
        tmp = tmp->prev;
    }

    while (carry) {
        pushList(list, carry % 10);
        carry = carry / 10;
        size++;
    }


    return size;
}



void factorial(int n) {
    pushList(list, 1);

    for (int i = 2; i <= n; i++) {
        res_size = multiply(i);
    }

    printDblLinkedList(list);


}
int check_int()
{
    int a;
    rewind(stdin);
    while (!scanf("%d", &a) || a <= 0)
    {
        rewind(stdin);
        printf("Incorrect enter, enter correct data(more than 0): ");
    }
    return a;
}

int main()
{
    int n;
    printf("Enter a number: \n");
    n = check_int();
    //scanf("%d", &n);
    factorial(n);
    _getch();
}