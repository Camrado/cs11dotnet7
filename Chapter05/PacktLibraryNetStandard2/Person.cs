namespace Packt.Shared; // file-scoped namespace

public class Person {
    // fields
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavouriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    
    // constants
    public const string Species = "Homo Sapiens";
}