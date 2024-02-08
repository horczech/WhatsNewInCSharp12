namespace PrimaryConstructors;

//Notes:
// - is it a private field?
// - are they mutable?
// - are they properties?
// - how to add more constructors?
// - how to use inheritance?
// - does Dependency Injection works with primary constructors?

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;

    public Person(string firstName, string lastName) {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FullName() {
        return $"{_firstName} {_lastName}";
    }
}

public record PersonRecord(string FirstName, string LastName);
    
