using System;
namespace apitest.UseCase
{
    public interface IFileSave
    {
        public Task<string> GetFileSaveAsync(string text);
    }
}

