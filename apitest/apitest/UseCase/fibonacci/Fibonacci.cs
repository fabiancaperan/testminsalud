using System;
namespace apitest.UseCase.fibonacci
{
    public class Fibonacci : IFibonacci
    {
        public int GetFibonacci(int num)
        {
            if (num < 2)
            {
                return num;
            }
            else
            {
                return GetFibonacci(num - 1) + GetFibonacci(num - 2);
            }
        }

       
    }
}

