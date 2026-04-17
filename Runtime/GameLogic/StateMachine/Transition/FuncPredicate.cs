using System;

namespace Dave6.Foundation.GameLogic.State
{
    public class FuncPredicate : IPredicate
    {
        readonly Func<bool> _Func;
        public FuncPredicate(Func<bool> func) => _Func = func;
        public bool Evaluate() => _Func.Invoke();
    }
}