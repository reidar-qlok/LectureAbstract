using System;

namespace LectureAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new DerivedClass();
            obj.NumberMethod();
            Console.WriteLine($"nr1 = {obj.First}, nr2 = {obj.Second}");
        }
    }
    class DerivedClass : Numbers
    {
        public override int First
        {
            get
            {
                return nr1 + 4;
            }
        }
        public override int Second
        {
            get
            {
                return nr2 + 2;
            }
        }
        public override void NumberMethod()
        {
            nr1++;
            nr2++;
        }
    }
}
