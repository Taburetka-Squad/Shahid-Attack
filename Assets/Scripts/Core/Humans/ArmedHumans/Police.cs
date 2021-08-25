namespace Core.Humans.ArmedHumans
{
    public class Police : ArmedHuman
    {
        private void Update()
        {
            DirectionInput.Read();
            ShootInput.Read();
        }
    }
}