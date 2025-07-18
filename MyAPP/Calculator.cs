using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP
{
    public interface ICalculator
    {
        int Add(int num, int addNum);
        int Subtract(int num, int subNum);
        int Multiply(int num, int mulNum);
        int Divide(int num, int nivNum); // 除數為 0 時應拋出例外
    }

    public class Calculator : ICalculator
    {
        public int Add(int num, int addNum)
        {
            try
            {
                return checked(num + addNum);
            }
            catch (Exception)
            {
                throw;
            }        
        }

        public int Subtract(int num, int subNum)
        {
            try
            {
                return checked(num - subNum);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Multiply(int num, int mulNum)
        {
            try
            {
                return checked(num * mulNum);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Divide(int num, int divNum)
        {
            try
            {
                return checked(num / divNum);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
