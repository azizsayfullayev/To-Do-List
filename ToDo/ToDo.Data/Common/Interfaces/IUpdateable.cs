namespace ToDo.Data.Common.Interfaces;

public interface IUpdateable<T> where T : class
{
    public Task<T> UpdateAsync(int id, T entity);
}
