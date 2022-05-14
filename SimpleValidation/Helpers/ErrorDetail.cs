namespace SimpleValidation.Helpers
{
    /// <summary>
    /// Container for property name and validation error message for fluent validation
    /// </summary>
    public class ErrorDetail
    {
        /// <summary>
        /// Property
        /// </summary>
        public string PropertyName { get; }
        /// <summary>
        /// Validation error message
        /// </summary>
        public string Message { get; }

        public ErrorDetail(string propertyName, string message)
        {
            PropertyName = propertyName;
            Message = message;
        }

        public override string ToString() => PropertyName;
    }
}