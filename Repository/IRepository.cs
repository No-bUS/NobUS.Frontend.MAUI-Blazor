﻿namespace NobUS.Frontend.MAUI_Blazor.Repository
{
    public interface IRepository<T> where T : class
    {
        public IRepository<T> RegisterSource(Func<Task<IEnumerable<T>>> source);
        Task<IEnumerable<T>> GetAll();
        Task<IRepository<T>> Refresh();
    }
}
