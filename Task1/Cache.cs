public static class Cache<T>
{
    public static void Add(T entity)
    {
        Cache<T>.Add(entity);
    }
    public static void Remove(T entity)
    {
        Cache<T>.Remove(entity);
    }
    public static T Get(T entity)
    {
        return entity;
    }
}