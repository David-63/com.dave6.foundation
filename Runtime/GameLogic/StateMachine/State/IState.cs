namespace Dave6.Foundation.GameLogic.State
{
    public interface IState
    {
        void OnEnter();
        void Update();
        void FixedUpdate();
        void LateUpdate();
        void OnExit();

        bool CanBeOverridden();
        bool CanOverrideBy(IState next);
        bool CanExit();
    }
}