namespace ToDo.Data.Common.Interfaces;

public interface IDeleteable<T>
{
    public Task<T> DeleteAsync(int id);
}
