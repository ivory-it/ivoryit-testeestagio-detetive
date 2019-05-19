# ivoryit-testeestagio-detetive

Na gloriosa cidade de Springfield o banqueiro Carlos Fortuna foi assassinado em sua mansão. O investigador Holmes foi escolhido para investigar este caso. Após uma série de investigações, ele organizou uma lista com prováveis assassinos, os locais do crime e armas que poderiam ter sido utilizadas.

### Suspeitos

1 - Advogado Sr. Marinho
2 - Chef. de Cozinha Tony Gourmet
3 - Coveiro Sérgio Sortuno
4 - Dançarina Srta. Rosa
5 - Florita Dona Branca
6 - Médica Dona Violeta
7 - Mordomo James
8 - Sargento Bigode

### Locais

1 - Biblioteca
2 - Cozinha
3 - Hall
4 - Escritório
5 - Sala de estar
6 - Sala de jantar
7 - Sala de música
8 - Salão de festas
9 - Salão de jogos

### Armas

1 - Castiçal
2 - Cano
3 - Chave inglesa
4 - Corda
5 - Revólver
6 - Faca


Uma testemunha foi encontrada, mas ela só consegue responder se Lin fornecer uma teoria. Para cada teoria ele "chuta" um assassino, um local e uma arma. A testemunha então responde com um número. Se a teoria estiver correta (assassino, local e arma corretos), ela responde 0. Se a teoria está errada, um valor 1,2 ou 3 é retornado. 1 indica que o assassiona está incorreto; 2 indica que o local está incorreto; 3 indica que a arma está incorreta. Se mais de uma suposição está incorreta, ela retorna um valor arbitrário entre as que estão incorretos (isso é totalmente aleatório).

Por exemplo, se o assassino for Donald Duck Knuth usando um trezoitão em Tokio:

Teoria: 1, 1, 1
Retorno: 1, ou 2, ou 3 (todos estão incorretos) 

Teoria: 3, 1, 3
Retorno: 1, ou 3 (somente o local está correto)

Teoria: 5, 3, 4
Retorno: 1 (somente o assassino está incorreto)

Teoria: 2, 3, 4
Retorno: 0 (todos corretos, você solucionou o caso)

Você precisa desenvolver um programa que tente resolver o problema. Inicialmente não se preocupe no número de tentativas necessário para encontrar a solução. Depois tente melhorar a maneira com que as teorias são testadas para que Lin encontre a solução do problema no menor número de tentativas.
