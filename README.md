# longSlice

La consegna chiede di trovare il prodotto più grande per una sottostringa contigua di cifre di una data stringa di cifre.

La soluzione proposta utilizza due cicli for innestati: il primo ciclo scorre la stringa dall'inizio alla fine, mentre il secondo ciclo scorre una sottostringa contigua di lunghezza `span` a partire dalla posizione corrente del primo ciclo. Il prodotto dei numeri di questa sottostringa viene calcolato e confrontato con il prodotto massimo trovato finora.


Il codice inizia con alcune verifiche sulla validità dei dati in input: verifica se `span` è zero, se `span` è negativo o maggiore della lunghezza della stringa di cifre, e se la stringa contiene solo cifre. In caso contrario, viene sollevata un'eccezione `ArgumentException`.

Il primo ciclo for scorre la stringa `digits` dall'inizio alla fine, utilizzando la variabile `i` come indice di partenza. Il secondo ciclo for, invece, scorre una sottostringa contigua di `digits` di lunghezza `span` a partire dalla posizione corrente `i`. 

Per calcolare il prodotto dei numeri della sottostringa corrente, il secondo ciclo for scorre la sottostringa usando la variabile `j` come indice di partenza. In ogni iterazione del ciclo, viene estratto il valore numerico corrispondente al carattere `j` della sottostringa sottraendo il valore ASCII del carattere '0'. Il valore numerico ottenuto viene poi moltiplicato per il prodotto parziale `prodotto`.

Dopo che il secondo ciclo for ha completato la scansione della sottostringa corrente, il prodotto parziale viene confrontato con il prodotto massimo trovato finora (`maxProduct`). Se il prodotto parziale è maggiore di `maxProduct`, allora `maxProduct` viene aggiornato con il nuovo valore.

Alla fine dei due cicli for, il valore di `maxProduct` rappresenta il prodotto più grande per una sottostringa contigua di `digits` di lunghezza `span`. Il valore viene restituito come risultato della funzione.

In caso di dati in input non validi, come `span` uguale a zero, `span` negativo o maggiore della lunghezza di `digits`, o `digits` contenente caratteri che non sono cifre, viene sollevata un'eccezione `ArgumentException`.
