# Detetive
Na gloriosa cidade de Springfield o banqueiro Carlos Fortuna foi assassinado em sua mansão. O investigador Holmes foi escolhido para solucionar este caso. Após uma série de investigações, ele organizou uma lista com prováveis assassinos, locais e armas.

## Confidêncial
### Suspeitos
|   |  |
| ------------- | ------------- |
| ![1 - Advogado Sr. Marinho](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem1.jpg) | 1 - Advogado Sr. Marinho  |
| ![2 - Chef. de Cozinha Tony Gourmet](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem2.jpg) | 2 - Chef. de Cozinha Tony Gourmet  |
| ![3 - Coveiro Sérgio Sortuno](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem3.jpg) | 3 - Coveiro Sérgio Sortuno  |
| ![4 - Dançarina Srta. Rosa](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem4.jpg) | 4 - Dançarina Srta. Rosa |
| ![5 - Florista Dona Branca](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem5.jpg) | 5 - Florista Dona Branca |
| ![6 - Médica Dona Violeta](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem6.jpg) | 6 - Médica Dona Violeta |
| ![7 - Mordomo James](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem7.jpg) | 7 - Mordomo James |
| ![8 - Sargento Bigode](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/personagem8.jpg) | 8 - Sargento Bigode |

### Locais
|   |                 |
| - | --------------- |
| ![1 - Biblioteca](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local1.jpg) | 1 - Biblioteca      |
| ![2 - Cozinha](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local2.jpg) | 2 - Cozinha         |
| ![3 - Hall](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local3.jpg) | 3 - Hall            |
| ![4 - Escritório](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local4.jpg) | 4 - Escritório      |
| ![5 - Sala de estar](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local5.jpg) | 5 - Sala de estar   |
| ![6 - Sala de jantar](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local6.jpg) | 6 - Sala de jantar  |
| ![7 - Sala de música](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local7.jpg) | 7 - Sala de música  |
| ![8 - Salão de festas](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local8.jpg) | 8 - Salão de festas |
| ![9 - Salão de jogos](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/local9.jpg) | 9 - Salão de jogos  |

### Armas
|   |               |
| - | ------------- |
| ![1 - Castiçal](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/arma1.jpg) | 1 - Castiçal      |
| ![2 - Cano](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/arma2.jpg) | 2 - Cano          |
| ![3 - Chave inglesa](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/arma3.jpg) | 3 - Chave inglesa |
| ![4 - Corda](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/arma4.jpg) | 4 - Corda         |
| ![5 - Revólver](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/arma5.jpg) | 5 - Revólver      |
| ![6 - Faca](https://github.com/ivory-it/ivoryit-testeestagio-detetive/blob/master/imagens/arma6.jpg) | 6 - Faca          |

## Testemunha
Uma testemunha foi encontrada, mas ela só consegue responder se Holmes fornecer uma teoria. Para cada teoria ele deve perguntar sobre um suspeito, local e arma. A testemunha então responde com um número: 
- **0** caso a teoria estiver correta;
- **1** indica que o suspeito está incorreto; 
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
- Retorno: 0 (todos corretos, você solucionou o caso :smirk:)

## Desafio
Você precisa desenvolver um programa que tente resolver o problema com o menor número de perguntas realizadas a testemunha.

### Roteiro
1. Ter uma conta no GitHub;
2. Realizar o `fork` deste repositório para sua conta. Assim você terá uma copia do projeto base;
3. Uma vez com o projeto em sua conta, realize o `clone` da mesma para codificar;
4. Abra a solução no VisualStudio/VisualCode (O projeto base é uma console application utilizando .Net Framework 4.6);
5. Ao abrir o projeto a classe `Program.cs` terá uma instância da classe `Testemunha.cs` criada, `var testemunha = new Testemunha();`. Se você analisar o construtor desta classe, verá que ela irá criar um crime de forma aleatória. Portanto a testemunha já visualizou o crime e possui em sua memória um criminoso, local e arma;
6. Ainda na classe `Testemunha.cs`, repare que existe um método intitulado `Interrogar`. Com ele podemos testar as teorias, basta passar um número que identifique um criminoso, local e arma. Que o método irá lhe responder coforme descrito logo acima na sessão Testemunha;
7. Portanto na classe `Program.cs` no comentário `Escreva seu código aqui.`, escreva uma algoritimo que simule um detetive realizando as perguntas utilizando o método `testemunha.Interrogar(criminoso, local, arma)`. Toda vez que você chamar esté método, o mesmo irá contabilizar uma tentativa, repare que no final do programa existe uma linha que imprime a número de tentativa. Está linha deverá somente ser executada após o detetive realizar todas as perguntas e receber da testemunha uma resposta de número 0 (criminoso, local e arma corretos);
8. Após finalizar, basta subir as alterações (commit/push) para sua conta. E responder o e-mail do teste com o link da sua conta no GitHub.

### Dicas / Regras
1. Ao codificar matenha seu código limpo e coerente. Manter padronização ajuda a equipe entender o que foi codificado, além de ajudar na manutenção futuras. Algumas dicas: ![Padronização Códificação](https://github.com/ivory-it/ivoryit-testeestagio-detetive/wiki/Padroniza%C3%A7%C3%A3o-codifica%C3%A7%C3%A3o);
2. A classe `Testemunha.cs` não pode ser modificada;
3. Qualquer duvida entre em contato: thiago.resende@ivoryit.com.br
