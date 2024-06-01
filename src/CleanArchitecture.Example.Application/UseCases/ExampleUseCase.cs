using CleanArchitecture.Example.Application.Common.Boundaries;
using FluentValidation;

namespace CleanArchitecture.Example.Application.UseCases
{
    public static class ExampleUseCase
    {
        public class Request : IRequest
        {
            public string SomeString { get; set; }
            public int SomeNumber { get; set; }
        }

        public class RequestValidator : AbstractValidator<Request>
        {
            public RequestValidator()
            {
                RuleFor(r => r.SomeNumber).GreaterThan(0);
                RuleFor(r => r.SomeString).NotEmpty();
            }
        }

        public class UseCase : IUseCase<Request>
        {
            public Task Handle(Request request)
            {
                throw new NotImplementedException();
            }
        }
    }
}
