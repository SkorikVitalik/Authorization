namespace domain;
public class RefreshSession
{
    public Guid Id {get; private set;}
    public string RefreshToken {get; private set;}
    public Guid UserId {get; private set;}
    public string fingerSprint {get; set;}
    
}