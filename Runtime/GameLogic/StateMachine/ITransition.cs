namespace Dave6.Foundation.GameLogic.State
{
    public interface ITransition
    {
        IState To { get; }
        IPredicate Condition { get; }
    }
}