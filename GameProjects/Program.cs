using GameProjects;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer 
{
    Id = 1, BirthYear = 1999, 
    FirstName = "Yunus", 
    LastName = "Şahin", 
    IdentityNumber = 12345
});

