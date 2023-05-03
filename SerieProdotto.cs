using System;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        // Converti la stringa di cifre in un array di caratteri
        char[] numeri = digits.ToCharArray();
    
        // Inizializza il massimo prodotto trovato a 0
        int maxProduct = 0;

        // Verifica se `span` è zero e restituisci 1 (il prodotto di una sottostringa vuota è 1)
        if( span==0 )
            return 1;

        // Verifica se `span` è negativo, se la stringa di cifre è vuota o se `span` è maggiore della lunghezza della stringa
        // Se una di queste condizioni è verificata, solleva un'eccezione `ArgumentException`
        if( span<0 || digits==""|| span > digits.Length)
            throw new ArgumentException();

        // Verifica che la stringa di cifre contenga solo cifre (e non lettere o simboli)
        for (int i = 0; i < digits.Length; i++)
        {
            if(char.IsLetter(numeri[i]))
            {
                throw new ArgumentException();
            }
        }

        // Ciclo for che scorre la stringa di cifre dall'inizio alla fine
        for (int i = 0; i <= digits.Length - span; i++)
        {
            // Inizializza il prodotto della sottostringa contigua corrente a 1
            int prodotto = 1;

            // Ciclo for che scorre la sottostringa contigua di lunghezza `span` a partire dalla posizione corrente
            for (int j = i; j < i + span; j++)
            {
                // Converti il carattere corrente della sottostringa in un numero intero
                int digit = digits[j] - '0';
                // Moltiplica il prodotto corrente per il numero corrente della sottostringa
                prodotto *= digit;
            }

            // Confronta il prodotto della sottostringa corrente con il massimo prodotto trovato finora
            if (prodotto > maxProduct)
            {
                // Se il prodotto corrente è maggiore del massimo prodotto trovato finora, sostituisci il massimo prodotto con il prodotto corrente
                maxProduct = prodotto;
            }
        }

        // Restituisci il massimo prodotto trovato
        return maxProduct;

    }
}
