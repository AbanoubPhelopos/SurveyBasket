namespace Survey.Application.Services;

public interface IPollServices
{ 
    List<Poll> GetAll();
    Poll? Get(Guid Id);
}