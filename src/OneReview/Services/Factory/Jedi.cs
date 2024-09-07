namespace OneReview.Services;

public class Jedi : Character
{
    private ForceEvent _forceEvent;
    public Jedi(ForceEvent forceEvent)
    {
        _forceEvent = forceEvent;
    }

    public override void Fight()
    {
        Console.WriteLine("El Jedi pelea con su sable");
        _forceEvent.UseForce("Empuja a los enemigos");
    }
}