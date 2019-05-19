# ivoryit-testeestagio-detetive

Na gloriosa cidade de Springfield o banqueiro Carlos Fortuna foi assassinado em sua mansão. O investigador Holmes foi escolhido para investigar este caso. Após uma série de investigações, ele organizou uma lista com prováveis assassinos, os locais do crime e armas que poderiam ter sido utilizadas.

## Confidêncial
### Suspeitos
|   |  |
| ------------- | ------------- |
| ![1 - Advogado Sr. Marinho](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem1.jpg) | 1 - Advogado Sr. Marinho  |
| ![2 - Chef. de Cozinha Tony Gourmet](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem2.jpg) | 2 - Chef. de Cozinha Tony Gourmet  |
| ![3 - Coveiro Sérgio Sortuno](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem3.jpg) | 3 - Coveiro Sérgio Sortuno  |
| ![4 - Dançarina Srta. Rosa](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem4.jpg) | 4 - Dançarina Srta. Rosa |
| ![5 - Florita Dona Branca](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem5.jpg) | 5 - Florita Dona Branca |
| ![6 - Médica Dona Violeta](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem6.jpg) | 6 - Médica Dona Violeta |
| ![7 - Mordomo James](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem7.jpg) | 7 - Mordomo James |
| ![8 - Sargento Bigode](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/personagem8.jpg) | 8 - Sargento Bigode |

### Locais
|   |                 |
| - | --------------- |
| 1 | Biblioteca      |
| 2 | Cozinha         |
| 3 | Hall            |
| 4 | Escritório      |
| 5 | Sala de estar   |
| 6 | Sala de jantar  |
| 7 | Sala de música  |
| 8 | Salão de festas |
| 9 | Salão de jogos  |

### Armas
|   |               |
| - | ------------- |
| 1 | Castiçal      |
| 2 | Cano          |
| 3 | Chave inglesa |
| 4 | Corda         |
| 5 | Revólver      |
| 6 | Faca          |

## Testemunha
Uma testemunha foi encontrada, mas ela só consegue responder se Holmes fornecer uma teoria. Para cada teoria ele deve perguntar sobre um suspeito, local e arma. A testemunha então responde com um número: 
- **0** caso a teoria estiver correta;
- **1** indica que o assassiono está incorreto; 
- **2** indica que o local está incorreto;
- **3** indica que a arma está incorreta.

**Exemplo:**

Se o assassino for **2 - Chef. de Cozinha Tony Gourmet**, na **2 - Cozinha** e usando **4 - Corda** (2, 2, 4):

**Teoria: 1, 1, 1**
- Retorno: 1, 2 ou 3 (todos estão incorretos) 

**Teoria: 1, 2, 1**
- Retorno: 1 ou 3 (somente o local está correto)

**Teoria: 1, 2, 4**
- Retorno: 1 (somente o assassino está incorreto)

**Teoria: 2, 2, 4**
- Retorno: 0 (todos corretos, você solucionou o caso)

Você precisa desenvolver um programa que tente resolver o problema. Inicialmente não se preocupe no número de tentativas necessário para encontrar a solução. Depois tente melhorar a maneira com que as teorias são testadas para que Lin encontre a solução do problema no menor número de tentativas.
