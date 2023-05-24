namespace MVCCircle.Logic
{
    public interface ICircelModel
    {
        double Radius { get; }

        event EventHandler? Changed;
    }
}