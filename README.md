# Exercício 3 - Events

1º Crie uma classe chamada Clock, que irá representar um cronômetro. Esta classe possui o 
método Start(), que inicia um loop infinito. A cada 1 segundo passado, este método chama 
métodos de callback registrados informando quantos segundos se passaram desde o início da 
contagem (a contagem inicia quando Start() é chamado). 

#
2º Para implementar este comportamento, você precisa de um delegate, que você chamará de 
SecondsHandler. Ele referencia métodos que recebem um parâmetro do tipo long (número 
de segundos) e retornam void. 
#
3º Crie um método chamado OnSecond() na sua aplicação, que é chamado via delegate pelo 
objeto Clock a cada segundo. Imprima na tela o valor do segundo fornecido. 
Dica: Utilize a chamada Thread.Sleep(1000) para fazer a aplicação pausar por 1 segundo. A 
classe Thread pertence ao namespace System.Threading. 
#
4º utilize um event para notificar os 
interessados a respeito da passagem do tempo. 
Use o padrão de eventos definido pela Microsoft, onde o método chamado deve receber dois 
parâmetros: um object, que identifica o gerador do evento; e um objeto da classe 
SecondElapsedEventArgs, que será criada por você e conterá as informações do evento 
(neste caso, o número de segundos passados).
