# DIO - Trilha .NET - Programação orientada a objetos

www.dio.me

## Desafio de projeto

Para este desafio, foi necessário usar 0s conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto

A proposta do desafio consistia em modelar um sistema que trabalha com celulares. Para isso, foi solicitado uma abstração de um celular que disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta

Para cumprir o desafio foi preciso criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone.
Criar as classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações

1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução

O código foi fornecido pela metade, e foi solicitado dar continuidade obedecendo as regras descritas acima, para que no final, obtivéssemos um programa funcional.
