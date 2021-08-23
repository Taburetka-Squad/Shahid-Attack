using Core.InputProviders;

namespace Core.Humans.ArmedHumans
{
    public abstract class ArmedHuman : Human
    {
        protected override IInput Input => ShootInput;
        protected abstract IShootInput ShootInput { get; }

        protected abstract override void Move();
    }
}