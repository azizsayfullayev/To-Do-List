namespace ToDo.Data.Common.Interfaces;

public interface ICreateable<T> 
{
    Task<bool> CreateAsync(T entity);
}
