namespace PrimaryConstructors;

public struct PersonStruct
{
    public string FirsName;
    public string LastName;
}

public struct NewPersonStruct(string firstName, string lastName);
