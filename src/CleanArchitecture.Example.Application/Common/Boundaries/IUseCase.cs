namespace CleanArchitecture.Example.Application.Common.Boundaries
{
    internal interface IUseCase<in TRequest> where TRequest : IRequest
    {
        Task Handle(TRequest request);
    }
}
