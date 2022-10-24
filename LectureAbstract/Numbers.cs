using System;
using System.Collections.Generic;
using System.Text;

namespace LectureAbstract
{
    abstract class Numbers
    {
        protected int nr1 = 100;
        protected int nr2 = 150;
        public abstract void NumberMethod();

        public abstract int First { get; }
        public abstract int Second { get; }
    }
}
