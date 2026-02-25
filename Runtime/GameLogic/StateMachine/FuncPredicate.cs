using System;

namespace Dave6.Foundation.GameLogic.State
{
    public class FuncPredicate : IPredicate
    {
        readonly Func<bool> func;
        public FuncPredicate(Func<bool> func) => this.func = func;
        public bool Evaluate() => func.Invoke();
    }
}