namespace PrimaryConstructors;

//Notes:
// - is it a private field?
// - how to add more constructors?
// - use case for props initialization 
// - Dependency Injection
// - Primary constructor parameters may not be stored if they aren't needed
// - Primary constructor parameters aren't members of the class. For example, a primary constructor parameter named firstName can't be accessed as this.firstName
// - Primary constructor parameters are mutable
// - Primary constructor parameters don't become properties.
// - use-case: initialize base class

public class Person(string firstName, string lastName)
{
    public string FullName() {
        return $"{firstName} {lastName}";
    }
}