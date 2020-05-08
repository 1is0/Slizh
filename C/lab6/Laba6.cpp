#include <stdio.h>
#include <cstdlib>
#include <conio.h>

const int Border = 3;

struct Node //описание узла списка
{
    int number; // номер дерева
    int value; // то, что мы добавляем в либо удаляем из дерева
    char rule;//признак выполняемого действия
    Node* next; //указатель на следующий элемент
};

#define NIL &sentinel
struct Node sentinel = { 0, 0, '\0', NIL };

struct Queue //описание очереди
{
    int size; //счетчик размера очереди
    Node* first; //указатель на начало очереди
    Node* last; //указатель на конец очереди
};

typedef struct ROOT//Структура "Дерево"
{
    int number;
    int count;
    struct ROOT* left, * right, * parent;// указатель на правого и левого потомка.
} ROOT;

void Creation(Queue* Q) //создание очереди
{
    Q->first = NIL;
    Q->last = NIL;
    Q->first->next = Q->last;
}


ROOT* Delete(ROOT* node, int val) {
    if (node == NULL)
        return node;

    if (val == node->number) {

        ROOT* tmp;
        if (node->right == NULL)
            tmp = node->left;
        else {

            ROOT* ptr = node->right;
            if (ptr->left == NULL) {
                ptr->left = node->left;
                tmp = ptr;
            }
            else {

                ROOT* pmin = ptr->left;
                while (pmin->left != NULL) {
                    ptr = pmin;
                    pmin = ptr->left;
                }
                ptr->left = pmin->right;
                pmin->left = node->left;
                pmin->right = node->right;
                tmp = pmin;
            }
        }

        free(node);
        return tmp;
    }
    else if (val < node->number)
        node->left = Delete(node->left, val);
    else
        node->right = Delete(node->right, val);
    return node;
}

bool Empty(Queue* Q) //проверка очереди на пустоту
{
    if (Q->first->next == Q->last) return true;
    else return false;
}


int Top(Queue* Q) //вывод начального элемента
{
    if (Q->first->next && Q->first->next != NIL)
        return Q->first->next->number;
    else
        return -1;
}


void Add(struct Queue* Q) //добавление элемента
{
    int value = rand() % Border;
    int randNumber;
    char rule;
    printf("Enter a number, which u want to add(delete) to(from) %d tree):", value+1);
    scanf("%d", &randNumber);
    printf("Delete or add? A - add, D - delete\n");
    scanf(" %c", &rule);
    if (rule != 'A' && rule != 'D') {
        printf("Incorrect writing!");
        exit(1);
    }

    Node* tmp = Q->first;
    while (tmp->next != NIL)
        tmp = tmp->next;
    if (tmp == NIL)
    {
        tmp = Q->first->next = (Node*)malloc(sizeof(Node));
        tmp->next = NIL;
    }
    else
    {
        tmp->next = (Node*)malloc(sizeof(Node));
        tmp = tmp->next;
        tmp->next = NIL;
    }

    tmp->number = value;
    tmp->value = randNumber;
    tmp->rule = rule;
    tmp->next = NIL;
}


struct ROOT* Insert(struct ROOT* root, int x)// добавление символа из строки в дерево
{
    if (root == nullptr)// если дерево пустое, то
    {
        root = (ROOT*)malloc(sizeof(ROOT));
        root->number = x; // в корень кладём наш символ
        root->count = 1;
        root->left = root->right = NULL;// правый и левый потомки пока что не существуют, есть только корень.
        root->parent = NULL;
        return root;
    }
    else // иначе
    {
        /*if (root->number == x) //  если символ из данного узла равен проверяемому символу x, то
            root->count++; // увеличиваем счетчик в данном узле на единицу*/
            //else// иначе
        if (root->number > x) // если наш проверяемый символ находится в алфавите до символа из узла, то
        {
            root->left = Insert(root->left, x);// идем по левой части дерева(рекурсия)
            root->left->parent = root;
        }
        else
        {
            root->right = Insert(root->right, x);// иначе, идем по правой части.
            root->right->parent = root;
        }
    }
}


int Minimum(struct ROOT* root) {
    if (!root) return -2030300;
    if (root->left != nullptr) return Minimum(root->left);
    else return root->number;
}


void Display(struct ROOT* root) // показать все буквы, хранящиеся в дереве, и их кол-во.
{
    if (root != nullptr)
    {
        Display(root->left);
        getchar();
        printf("%d : %d\n", root->number, root->count);
        Display(root->right);
    }
}

struct Node Pop(struct Queue* q)
{
    if (q->first->next && q->first->next != NIL)
    {
        struct Node toReturn = *(q->first->next);
        Node* tmp = q->first->next->next;
        free(q->first->next);
        q->first->next = tmp;
        return toReturn;
    }
    else
        return {};
}


char Exist(struct ROOT* root, int number)
{
    if (!root)
        return 0;
    if (root->number == number)
    {
        root->count++;
        return 1;
    }
    return Exist(root->left, number) || Exist(root->right, number);
}


void VRootEpal(struct Queue* q, struct ROOT* roots) {
    Node tmp;
    while (!Empty(q)) {
        tmp = Pop(q);
        int i = tmp.number;
        if (tmp.rule == 'A')
            Insert(roots, tmp.value);
        else
            Delete(roots, tmp.value);
    }
}





int main() {
    Queue* q = (Queue*)malloc(sizeof(Queue));
    Creation(q);
    int num;

    ROOT* arrayOfRoots[Border];
    for (int i = 0; i < Border; i++)
        arrayOfRoots[i] = NULL;

    printf("How many elements are in queue?");
    scanf("%d", &num);


    for (int i = 0; i < num; i++)
        Add(q);

    Node tmp;
    while (!Empty(q)) {
        tmp = Pop(q);
        int i = tmp.number;
        if (tmp.rule == 'A') {
            if (!Exist(arrayOfRoots[2], tmp.value))
                arrayOfRoots[2] = Insert(arrayOfRoots[2], tmp.value);
        }
        else
            arrayOfRoots[2] = Delete(arrayOfRoots[2], tmp.value);
    }


    for (int i = 0; i < Border; i++)
        Display(arrayOfRoots[i]);

    _getch();
    return 0;
}