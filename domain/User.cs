namespace domain;
public class User
{
    public Guid Id {get;  private set;} = null!;
    public string Email {get; private set;} = null!;
    public string Login {get; private set;} = null!;
    public User(Guid id, string email, string login)
    {
        Id = id;
        Email = email;
        Login = login;
    }
}
