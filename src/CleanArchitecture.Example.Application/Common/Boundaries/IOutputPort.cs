namespace CleanArchitecture.Example.Application.Common.Boundaries
{
    public interface IOutputPort
    {
        void HandleSuccess();
    }

    public interface IOutputPort<in TUseCaseResponse>
    {
        void HandleSuccess(TUseCaseResponse useCaseResponse);
    }
}
