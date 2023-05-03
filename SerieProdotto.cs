using System;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {

        char[] numeri = digits.ToCharArray();
        int maxProduct = 0;

        if( span==0 )
            return 1;


        if( span<0 || digits==""|| span > digits.Length)
            throw new ArgumentException();
            

        for (int i = 0; i < digits.Length; i++)
        {
            if(char.IsLetter(numeri[i]))
            {
                throw new ArgumentException();
            }
        }

        

        for (int i = 0; i <= digits.Length - span; i++)
        {
            int prodotto = 1;

            for (int j = i; j < i + span; j++)
            {
                int digit = digits[j] - '0';
                prodotto *= digit;
            }

            if (prodotto > maxProduct)
            {
                maxProduct = prodotto;
            }
        }

        return maxProduct;

    }
}