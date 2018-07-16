# SystemEnvironmentAbstractions

A simple abstraction around System.Environment to make faking the Environment class possible.

## Old:
```csharp
public class DoWork()
{
    public void Invoke()
    {
        if(System.Environment.ProcessorCount > 1) // impossible to test
        {
            // your implementation
        }
    }
}
```

## New:

Inject SystemEnvironmentAbstractions.Environment into your class.

```csharp
public class DoWork()
{
    public DoWork(IEnvironment environment)
    {
        _environment = environment;
    }

    public void Invoke()
    {
        if(_environment.ProcessorCount > 1)
        {
            // your implementation
        }
    }
}
```
