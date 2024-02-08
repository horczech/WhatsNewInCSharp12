namespace PrimaryConstructors;

public class PersonBase(string firstName, string lastName) { }


public class Employee(string firstName, string lastName, string email) : PersonBase(firstName, lastName) { }