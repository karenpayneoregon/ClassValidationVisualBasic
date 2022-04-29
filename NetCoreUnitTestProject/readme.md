# About

Contains unit test for working with data annotations.

&check; Uses external asertion libraries which provide a richer experince and easier for others to read.

- [NFluent](https://www.n-fluent.net/)
- [FluentAssertions](https://fluentassertions.com/)

## Helpers

Once `EntityValidationResult result = Model.Validate(...);` has executed, execute the following when a model is invalid to get error messages.

```csharp
result.Errors.ToList().ForEach(Console.WriteLine);
```