namespace OneReview.Services;

public class SithFactory : CharacterFactory
{
    public override Character CreateCharacter()
    {
        return new Sith();
    }
}