> 🚀 **Jornada do Projeto: O Ponto de Partida**
>
> Bem-vindo(a) à primeira etapa deste projeto! Este repositório documenta a criação do **simulador desktop em C#**, que é o coração e a fundação do meu Trabalho de Conclusão de Curso (TCC).
>
> Aqui, você encontrará os detalhes da implementação da programação concorrente e da lógica da simulação. Para uma compreensão completa da evolução e dos desafios técnicos, recomendo ler a descrição das etapas abaixo.
>
> A jornada continua e é concluída no repositório final, que adiciona todo o módulo web:
>
> **[➡️ Ver a Versão Final e a Integração com Django (TCC)](https://github.com/ErickFernan/TCC_AltoForno_Django)**
---
# Alto-forno

<p align="justify"> 
  Este projeto foi desenvolvido para a disciplina de Automação em Tempo Real. Foi um projeto bastante desafiador pois a linguagem exigida era C# e nenhum estudante da disciplina
havia tido contato com a linguagem, então foi preciso aprender a linguagem ao mesmo tempo que cumpriamos os pedidos do professor. Dito isso, o forte deste projeto não é a 
organização mas sim seu funcionamento.

  O projeto foi realizado em três etapas, sendo elas:
</p>

1. Primeira etapa:

<p align="justify"> 
  A primeira parte do programa consistiu em desenvolver um programa onde um alto-forno tivesse uma reserva de 100 t e que essa reserva fosse processada a uma taxa de 1 t/s,
  quando um botão de "novo carrinho" fosse acionado iria entregar 10 toneladas ao reservatório. Mais algumas informações foram adicionadas ao layout.
  
  OBS.: Como o tempo era curto e eu ainda não sabia como gerar figurar via código, a animação é feita atraves de 100 imagens que são trocadas de acordo com a situação do reservatório.
</p>


<p align="center">
  <img src="https://user-images.githubusercontent.com/96123177/157297490-964318c0-fd35-4b89-b0b3-75b018e70c19.png?raw=true" alt="Sublime's custom image"/>
</p>

2. Segunda etapa:

<p align="justify"> 
  A segunda etapa foi um aperfeiçoamento da primeira, nela deveriamos construir uma estrada onde o carrinho levaria o produto a ser processado por uma distancia de 500 px com 
  uma velocidade de 5 px/s e deveriam ser adicionados alguns botões para comando. Nesta etapa já dominei a criação de figuras via código, dessa maneira refiz o design
  do alto-forno e desenhei um carrinho animado utilizando trigonometria para fazer a movimentação das rodas. Infelizmente, tive retirar a animação no projeto final, pois a quantidade
  de carrinhos a serem usadas era grande de mais e a vista "por cima" fazia mais sentido.
</p> 
  
<p align="justify">  
  Nesta etapa, também, foi adicionado o conceito de programação não linear usando threads, onde cada carrinho tinha seu próprio processo e armazenava suas próprias informações.
  Ou seja, ao gerar um novo carrinho uma thread era iniciada e quando o carrinho fazia sua entrega para o reservatório a mesma morria em sequência.
</p>


<p align="center">
  <img src="https://user-images.githubusercontent.com/96123177/157297495-93afa5a7-91a7-452f-a72d-8165dd73e5d3.png?raw=true" alt="Sublime's custom image"/>
</p>

3. Terceia etapa:

<p align="justify"> 
  Nesta parte foram adicionados mais alguns comandos, como o modo automático e manual na saída dos carrinhos, além da criação de um relatório que é salvo tanto em txt como 
  acessível usando TCP cliente e servidor.
  Além disso foi adicionado um trajeto para os dejetos do alto-forno, esse trajeto possui um cruzamento com a trilha principal, desta forma foi implementado um zona com "vagas limitadas" para as threads no cruzamento, onde utilizando a função mutex ou a semaphore podemos decidir quantas threads serão processadas naquele momento. 
</p>
  
<p align="justify">  
  Desta forma ao chegar no cruzamento
  as trilhas verificam as vagas, caso não haja vaga a thread fica esperando até uma surgir, uma nova vaga surge quando um carrinho sair da área de cruzamento, neste momento o próximo
  carrinho/thread da fila entra na vaga para completar seu percursso.

</p>

  No relatório é salvo o nome do carrinho, sua hora de início e o tempo gasto para completar o trajeto.
  

  Para um explicação mais detalhada [clique aqui](https://drive.google.com/drive/u/3/folders/1X1IT0A4PJ_PmLZ6IfgoLLwXkTIyAUpE-). Esse link contém minha apresentação final da disciplina.
  

<p align="center">
  <img src="https://user-images.githubusercontent.com/96123177/157297496-0e6a433f-95c3-47b1-b4c9-1063df5b7d27.png?raw=true" alt="Sublime's custom image"/>
</p>


Em caso de duvida, fique a vontade para entrar em contato.

---
## 🔗 Repositórios Relacionados

- **Versão anterior do projeto** (este repositório): [https://github.com/ErickFernan/Alto-forno](https://github.com/ErickFernan/Alto-forno)
- **Versão final do TCC** (projeto evoluído): [https://github.com/ErickFernan/TCC_AltoForno_Django](https://github.com/ErickFernan/TCC_AltoForno_Django)
