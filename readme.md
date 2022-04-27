### Basic class validation

This repository provides various code samples for validating data using [data annotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-5.0) and [FluentValidation](https://docs.fluentvalidation.net/en/latest/installation.html).

# Validating application data

Validation is the first and most important step in securing an application. It prevents the application from processing unwanted inputs that may produce unpredictable results. Couple validation with properly transmitting data to a data source.

When validating data should there be instant feedback? This is subjective, instant feedback will be better when there are many inputs so this would be better than waiting to submit their input. In the case of instant feedback there needs to be events triggered to perform validation while on submit there is a central generic method to perform validation.

Let's take another view of validating on submit, with all types of application which can be created with Visual Studio there are methods which permit displaying messages to assist the user to correct mistakes. So back to subjective, it may come down to if code is written in a team or individual in regards to, are there team rules or it's the Wild West.

## Preface

This repository contains validation code samples for user input, not validation of data coming from a database or other external sources, for working with databases and external sources that deserves it's own article.


## Data annotations

With ASP.NET Core using [data annotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-5.0) the standard for validating a model is with the [Validator Class](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validator?view=net-5.0) which defines a helper class that can be used to validate objects, properties, and methods when it is included in their associated [ValidationAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validationattribute?view=net-5.0) attributes.


The ValidationAttribute class enforces validation, based on the metadata that is associated with the data table. You can override this class to create custom validation attributes.

**Example**

```csharp
public class Person
{
    public int Id { get; set; }
    [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
    [Required(ErrorMessage = "{0} Required")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
    public string FirstName { get; set; }

    [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
    [Required(ErrorMessage = "{0} Required")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
    public string LastName { get; set; }

    [ValidateYears(ErrorMessage = "Valid range for BirthDate is from {0} to {1}")]
    [Required(ErrorMessage = "{0} Required")]
    public DateTime BirthDate { get; set; }
}
```
| Property        |   Attribute    |   Description |
|:------------- |:-------------|:-------------|
| FirstName | RegularExpression | Minimum 3 characters required |
|       | Required | Must have a value couple with above, minimum of three characters |
|       | StringLength | Min of three characters, max of 30 characters |
| LastName | RegularExpression | Minimum 3 characters required |
|       | Required | Must have a value couple with above, minimum of three characters |
|       | StringLength | Min of three characters, max of 30 characters |
| BirthDate | ValidateYears | Custom attribute for range of years |

To validate an instance of `Person`, set up a unit test method where all properties are valid.

```csharp
[TestMethod]
[TestTraits(Trait.Annotations)]
public void ValidPerson()
{

    // arrange
    Person person = new ()
    {
        FirstName = "Mike",
        LastName = "Flowers",
        BirthDate = new DateTime(1932, Now.Month, Now.Day)
    };

    // act
    EntityValidationResult result = Model.Validate(person);

    // assert
    Check.That(result.IsValid).IsTrue();
}
```

Next setup another test method, in this case BirthDate is out of range.

```csharp
[TestMethod]
[TestTraits(Trait.Annotations)]
public void InvalidDateValidPerson()
{
    // arrange
    DateTime date = new (2022, 4, 27);

    Person person = new ()
    {
        FirstName = "Mike",
        LastName = "Flowers",
        BirthDate = new DateTime(1931, date.Month, date.Day)
    };

    // act
    EntityValidationResult result = Model.Validate(person);

    // assert
    Check.That(result.IsValid).IsFalse();

}
```

In both test, the following code validates an instance of `person`

```csharp
EntityValidationResult result = Model.Validate(person);
```

Followed by asking if the instance of `person` is valid by `IsValid` method. Check is from [NFluent](https://www.n-fluent.net/).

```csharp
Check.That(result.IsValid).IsFalse();
```

- All code to validate are in a class project in this solution under [BaseDataValidatorLibrary](https://github.com/karenpayneoregon/ClassValidationVisualBasic/tree/net-core-version/BaseDataValidatorLibrary).
- For a list of stock validation attributes see [System.ComponentModel.DataAnnotations Namespace](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-5.0).

## ASP.NET Core Razor

In markup, the following uses `asp-validation-for` tag helper, see [Validation Tag Helpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-6.0#the-validation-tag-helpers) documentation for more information on usage..

```asp
<div class="row">
    <div class="col-md-4">
        <form method="post">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>

            <div class="form-group">
                <label asp-for="Movie.Title" class="control-label"></label>
                <input asp-for="Movie.Title" class="form-control" />
                <span asp-validation-for="Movie.Title" class="text-danger"></span>
            </div>

            <!-- <snippet_ReleaseDate> -->
            <div class="form-group">
                <label asp-for="Movie.ReleaseDate" class="control-label"></label>
                <input asp-for="Movie.ReleaseDate" class="form-control" />
                <span asp-validation-for="Movie.ReleaseDate" class="text-danger"></span>
            </div>
            <!-- </snippet_ReleaseDate> -->

            <div class="form-group">
                <label asp-for="Movie.Description" class="control-label"></label>
                <input asp-for="Movie.Description" class="form-control" />
                <span asp-validation-for="Movie.Description" class="text-danger"></span>
            </div>

            <div class="form-group">
                <label asp-for="Movie.Price" class="control-label"></label>
                <input asp-for="Movie.Price" class="form-control" />
                <span asp-validation-for="Movie.Price" class="text-danger"></span>
            </div>

            <div class="form-group">
                <label asp-for="Movie.Genre" class="control-label"></label>
                <select asp-for="Movie.Genre" asp-items="@(Html.GetEnumSelectList<Genre>())" class="form-control"></select>
                <span asp-validation-for="Movie.Genre" class="text-danger"></span>
            </div>

            <div class="form-group">
                <div class="checkbox">
                    <input asp-for="Movie.PreOrder" />
                    <label asp-for="Movie.PreOrder"></label>
                </div>
            </div>

            <div class="form-group">
                <input type="submit" value="Create" class="btn btn-primary" />
            </div>
        </form>
    </div>
</div>
```

In code behind the model `Movies` is setup as follows [BindProperty](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.bindpropertyattribute?view=aspnetcore-5.0).

**BindPropertyAttribute**
An attribute that can specify a model name or type of IModelBinder to use for binding the associated property.
```csharp
[BindProperty]
public Movie Movie { get; set; }
```

In the Post action, [ModelState.IsValid](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-5.0) validates or invalidates properties in the model.

**Model state** represents errors that come from two subsystems: model binding and model validation. Errors that originate from model binding are generally data conversion errors. 


```csharp
public async Task<IActionResult> OnPostAsync()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    _context.Movies.Add(Movie);
    await _context.SaveChangesAsync();

    return RedirectToPage("./Index");
}
```












## FluentValidation

[FluentValidation](https://docs.fluentvalidation.net/en/latest/installation.html) is a validation library for .NET, used for building strongly typed validation rules for business objects.

Fluent validations use a Fluent interface and lambda expressions to build validation rules.






:raised_hand: **04/25/2022** version in branch [net-core-version](https://github.com/karenpayneoregon/ClassValidationVisualBasic/tree/net-core-version) includes C# .NET Core versions of original work done in .NET Framework.

# VB.NET

See [master branch](https://github.com/karenpayneoregon/ClassValidationVisualBasic)

Microsoft TechNet [.NET: Defensive data programming (Part 4) Data Annotation](https://social.technet.microsoft.com/wiki/contents/articles/53055.net-defensive-data-programming-part-4-data-annotation.aspx)