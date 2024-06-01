using FluentValidation.Results;

namespace CleanArchitecture.Example.Application.Exceptions
{
    public class ValidationException : Exception
    {
        private const string ValidationErrorMessage = "One or more validation errors occurred.";

        public ValidationException() : base(ValidationErrorMessage)
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IList<ValidationFailure> failures) : this()
        {
            var names = failures.Select(e => e.PropertyName).Distinct();
            foreach (var name in names)
            {
                var failure = failures
                    .Where(f => f.PropertyName == name)
                    .Select(f => f.ErrorMessage)
                    .ToArray();

                Errors.Add(name, failure);
            }
        }

        public IDictionary<string, string[]> Errors { get; }
    }
}
