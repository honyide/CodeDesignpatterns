using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeDesignLearn01
{
    
    abstract class operate
    {
        public abstract void operateMethod(int a ,int b); 
        
    }
    internal class add:operate
    {
        public override void operateMethod(int a ,int b)
        {
            Console.WriteLine(a + "+" + b+ "="+(a+b));
        }
    }
    internal class multiply : operate
    {
        public override void operateMethod(int a, int b)
        {
            Console.WriteLine(a + "*" + b + "=" + (a * b));
        }
    }
    internal class division : operate { 
        public override void operateMethod(int a, int b)
        {
            if (b != 0)
                Console.WriteLine(a + "/" + b + "=" + (a / b));
            else
                throw new DivideByZeroException();
        }
    }
    internal class substraction : operate
    {
        public override void operateMethod(int a, int b)
        {
            Console.WriteLine(a + "-" + b + "=" + (a - b));
        }
    }
    internal class custom
    {
        public operate operateOne=null;
        

        public void ask()
        {
            Console.WriteLine("输入第一个数字：");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("输入第二个数字：");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("输入操作符：");
            char c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '+':
                    operateOne = new add();
                    operateOne.operateMethod(a, b);
                    break;
                case '-':
                    operateOne = new substraction();
                    operateOne.operateMethod(a, b);

                    break;
                case '*':
                    operateOne = new multiply();
                    operateOne.operateMethod(a, b);

                    break;
                case '/':
                    operateOne = new division();
                    operateOne.operateMethod(a, b);

                    break;
                default: operateOne = null; break;
            }
        }
    }
}
