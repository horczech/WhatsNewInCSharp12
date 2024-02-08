using Microsoft.Extensions.Logging;

namespace PrimaryConstructors;

//Notes:
// - when converted we loose immutability
// - when assigned to private readonly field _logger we have 2 references
// - next year we may get readonly primary constructors!!

public class PersonWithDI
{
    private readonly ILogger<PersonWithDI> _logger;

    public PersonWithDI(ILogger<PersonWithDI> logger) {
        _logger = logger;
    }

    public void Test() {
        _logger.LogError("Something broken.");
    }
}