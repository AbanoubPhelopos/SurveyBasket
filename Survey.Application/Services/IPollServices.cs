namespace Survey.Application.Services;

public interface IPollServices
{ 
    List<Poll> GetAll();
    Poll? Get(Guid Id);
    Poll Add(Poll request);
    bool Update(Guid id,Poll request);
    bool Delete(Guid id);
}