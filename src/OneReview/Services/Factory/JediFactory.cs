namespace OneReview.Services;

public class JediFactory : CharacterFactory
{
    private ForceEvent _forceEvent;

    public JediFactory(ForceEvent forceEvent)
    {
        _forceEvent = forceEvent;
    }

    public override Character CreateCharacter()
    {
        return new Jedi(_forceEvent);
    }
}