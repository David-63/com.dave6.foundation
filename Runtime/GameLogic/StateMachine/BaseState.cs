namespace Dave6.Foundation.GameLogic.State
{
    public abstract class BaseState<TOwner> : IState
    {
        protected TOwner _Controller;

        public BaseState(TOwner controller) => _Controller = controller;
        public virtual void OnEnter() { }
        public virtual void OnExit() { }
        public virtual void Update() { }
        public virtual void FixedUpdate() { }
        public virtual void LateUpdate() { }
    }
}