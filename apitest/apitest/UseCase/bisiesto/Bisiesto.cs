using System;
namespace apitest.UseCase.fibonacci
{
    public class Bisiesto : IBisiesto
    {
        public bool GetBisisesto(long num)
        {
            return (num % 4 == 0 && num % 100 != 0 || num % 400 == 0);
        }

       
    }
}

