using Microsoft.Extensions.Logging;

namespace PrimaryConstructors;

//Notes:
// - when converted we loose readonly
// - when assigned to private readonly field _logger we have 2 references

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