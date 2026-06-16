## Desafios em C# para bootcamp  Back-end com .net

#### Desafio 1: Calculadora de idade

O usuário informa o ano em que nasceu e o sistema retorna quantos anos ele tem (considerando o ano atual).
```
Fórmula: idade = anoAtual - anoNascimento
```
Exemplo de entrada e saída:
```
Digite o ano atual: 2026
Digite o ano em que você nasceu: 1995
Você tem 31 anos.
```
💡 Dica: peça o ano atual ao usuário (mais simples) ou coloque um valor fixo no código.
Conceitos avaliados: Variáveis, int, operação matemática (módulos 2, 3).

----

#### Desafio 2: Receita de torta de tomate
O usuário informa quantas porções de torta de tomate deseja fazer. 

A receita original rende 4 porções. 

A aplicação deve mostrar a quantidade ajustada de cada ingrediente.
```
Fórmula: novaQuantidade = quantidadeOriginal * (porcoes / 4.0)
```

Regras:

- Receita original (4 porções): Farinha 2 xícaras, Tomate picado 1 xícara, Leite 200 ml, Ovos 2 unidades, Sal 1 colher.
- Atenção ao tipo: use double e divida por 4.0 (não 4) para manter casas decimais.

Exemplo de entrada e saída:
```
Quantas porções deseja fazer? 8
Ingredientes para 8 porções:
Farinha: 4 xícaras
Tomate picado: 2 xícaras
Leite: 400 ml
Ovos: 4 unidades
Sal: 2 colheres
```
Conceitos avaliados: Variáveis, double, operações matemáticas (módulos 2, 3).

----

#### Desafio 3: Ímpares de 200 a 0
Crie um programa que conte de 200 até 0 (decrescente) e mostre apenas os números ímpares.

Exemplo de entrada e saída:
```
199 197 195 193 ... 3 1
```
Conceitos avaliados: Laço for decrescente + operador % (módulos 3 e 7).

----
#### Desafio 4: Sistema de desconto na compra
O usuário informa o valor total da compra. 
O sistema aplica um desconto conforme as faixas abaixo e mostra o valor final.

Regras:

- valor < 100 → sem desconto
- valor >= 100 e < 500 → 5% de desconto
- valor >= 500 → 10% de desconto

Exemplo de entrada e saída:
```
Valor da compra: R$ 250
Desconto aplicado: 5%
Valor a pagar: R$ 237,50
```
Conceitos avaliados: Variáveis, double, if/else if/else (módulos 2, 3, 4).

----
#### Desafio 5: Controle de volume
Crie uma aplicação para controlar o volume de um aparelho de música. 
O volume começa em 50. Mínimo 0, máximo 100.

Regras:

- Menu: 1 - Mostrar volume | 2 - Aumentar | 3 - Diminuir | 4 - Sair
- Ao aumentar/diminuir, peça o quanto.
- Se a operação fizer o volume sair dos limites (abaixo de 0 ou acima de 100), mostre erro e mantenha o volume atual.
- Após cada operação, mostrar o volume atualizado e voltar ao menu.

Exemplo de entrada e saída:
```
Volume atual: 50
Opção: 2
Aumentar quanto? 30
Volume atual: 80
Opção: 2
Aumentar quanto? 50
Operação inválida! O volume máximo é 100.
Volume atual: 80
```
Conceitos avaliados: while + switch + if (limites) (módulos 4, 6, 8).
