
# Estudo de C# - Básico

Este repositório foi criado com o intúito de treinar um pouco de lógica e aprender C#.

## Variáveis e Tipos de Dados

Em C#, as variáveis são usadas para armazenar dados na memória. Cada variável tem um tipo de dado associado que determina o tipo de valor que pode ser armazenado nela. Alguns dos tipos de dados básicos incluem:

- `int`: para números inteiros.
- `double`: para números de ponto flutuante de dupla precisão.
- `bool`: para valores booleanos (verdadeiro ou falso).
- `string`: para sequências de caracteres.

```
int idade = 25;
double altura = 1.75;
bool temCarteiraMotorista = true;
string nome = "João";
```

## Manipulação de Strings

As strings são manipuladas usando métodos e operadores em C#.

```
string saudacao = "Olá, ";
string nome = "Maria";
string mensagem = saudacao + nome + "!";
```

## Operadores Aritméticos
C# possui operadores aritméticos para realizar operações matemáticas.

- `Soma "+"`
- `ubtração "-"`
- `Multiplicação "*"`
- `Divisão "/"`
- `Modulo "%"`

```
int soma = 5 + 3;
int subtracao = 10 - 4;
int multiplicacao = 3 * 6;
double divisao = 15.0 / 2;
int modulo = 7 % 3;
```

#### Modulo - %
O operador módulo (%) retorna o resto da divisão entre dois números inteiros. Ele é usado para calcular o valor que sobra após a divisão de um número pelo outro.

Exemplo:

```

int numero1 = 10;
int numero2 = 3;
int resto = numero1 % numero2; // O valor de 'resto' será 1, pois 10 dividido por 3 é 3 com um resto de 1.
```

O operador módulo pode ser útil em várias situações, como por exemplo, verificar se um número é par ou ímpar.

```

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " é um número par.");
    }
    else
    {
        Console.WriteLine(i + " é um número ímpar.");
    }
}
```
## Operadores Lógicos
Operadores lógicos são usados para avaliar condições.

- `AND "&&"`
- `OR "||"`
- `NOT "!"`

```

bool condicao1 = true;
bool condicao2 = false;

bool resultadoE = condicao1 && condicao2; // E lógico (AND)
bool resultadoOU = condicao1 || condicao2; // OU lógico (OR)
bool resultadoNao = !condicao1; // NÃO lógico (NOT)
```

## Operadores Relacionais
Operadores relacionais comparam valores.
- `Maior que >`
- `Menor que <`
- `Igual ==`
- `Diferente !=`

```

int numero1 = 10;
int numero2 = 5;

bool maiorQue = numero1 > numero2;
bool menorQue = numero1 < numero2;
bool igual = numero1 == numero2;
bool diferente = numero1 != numero2;
```
## Estruturas de Controle
As estruturas de controle permitem controlar o fluxo de execução do programa.


### Estrutura de Decisão - IF
A estrutura `if` permite que você execute um bloco de código se uma condição especificada for verdadeira. Você também pode usar `else` para executar um bloco de código alternativo se a condição não for verdadeira.

```
int idade = 17;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}
```

### Estrutura de Repetição - FOR
A estrutura for é usada para executar um bloco de código um número específico de vezes. É comumente usado quando você conhece a quantidade exata de iterações que deseja executar.

```
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Contagem: " + i);
}
```

### Estrutura de Repetição - WHILE
A estrutura while é usada para executar um bloco de código enquanto uma condição especificada for verdadeira. O bloco de código pode ser executado zero ou mais vezes, dependendo da condição.

```
int contador = 0;

while (contador < 3)
{
    Console.WriteLine("Contador: " + contador);
    contador++;
}
```

### Estrutura de Repetição (FOREACH)
A estrutura foreach é usada para percorrer elementos em uma coleção, como um array, lista ou conjunto. É especialmente útil quando você deseja percorrer todos os elementos sem a necessidade de controlar um contador.

```
string[] cores = { "vermelho", "azul", "verde", "amarelo" };

foreach (string cor in cores)
{
    Console.WriteLine("Cor: " + cor);
}
```

### Estrutura de Controle - Switch

A estrutura de controle `switch` é utilizada para avaliar uma expressão e executar diferentes ações com base nos valores possíveis dessa expressão. É uma alternativa ao uso de múltiplos `if-else if`.

```
int diaDaSemana = 3;

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}
```

## Funções e Métodos:
Em C#, funções e métodos são blocos de código reutilizáveis que executam uma tarefa específica. Funções podem receber argumentos, executar um conjunto de instruções e retornar um valor (ou não). Aqui está como você pode criar, chamar e retornar valores de funções:

### Criando Funções:

```
// Função que recebe dois números inteiros e retorna a soma
int Soma(int a, int b)
{
    return a + b;
}
```

### Chamando Funções:

```
int resultado = Soma(5, 3); // Chamando a função e armazenando o resultado
Console.WriteLine("Resultado da soma: " + resultado); // Imprime "Resultado da soma: 8"
```

### Retornando Valores:

```
double CalculaMedia(params double[] valores)
{
    double soma = 0;
    foreach (double valor in valores)
    {
        soma += valor;
    }
    return soma / valores.Length;
}
```

## Tratamento de Erros - Exceções:
As exceções são eventos anormais que ocorrem durante a execução do programa e podem interromper o fluxo normal. Em C#, você pode usar blocos try, catch e finally para lidar com exceções de maneira controlada.

### Lançando Exceções:

```
void Divide(int divisor, int dividendo)
{
    if (divisor == 0)
    {
        throw new DivideByZeroException("Não é possível dividir por zero.");
    }
    int resultado = dividendo / divisor;
    Console.WriteLine("Resultado: " + resultado);
}
```

### Capturando Exceções:

```
try
{
    Divide(0, 10); // Chama a função que lança uma exceção
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: " + ex.Message); // Captura a exceção e imprime a mensagem de erro
}
```

### Bloco Finally:
```
try
{
    // Código que pode lançar uma exceção
}
catch (Exception ex)
{
    // Lidar com a exceção
}
finally
{
    // Este bloco será executado independentemente se houve exceção ou não
}
```
