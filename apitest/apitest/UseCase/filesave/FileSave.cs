using System;
using System.Text;

namespace apitest.UseCase.fibonacci
{
    public class FileSave : IFileSave
    {
        public async Task<string> GetFileSaveAsync(string text)
        {
            var lines = text.Split(" ");
            
            string path = Path.Combine(Directory.GetCurrentDirectory() + @"\","docs" );
            Console.WriteLine(path);
            Directory.CreateDirectory(path);
            path = Path.Combine(path, text);

            using FileStream stream = new(path, FileMode.Create, FileAccess.ReadWrite);

            using StreamWriter writer = new(stream, new UTF8Encoding(false));

            

            foreach (string line in lines)
            {
                    await writer.WriteLineAsync(line);   
            }

            return "guardado con éxito";
        }

       
    }
}

