namespace Core.Humans.ArmedHumans
{
    public class Terrorist : ArmedHuman
    {
        private void Update()
        {
            DirectionInput.Read();
            ShootInput.Read();
        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}
