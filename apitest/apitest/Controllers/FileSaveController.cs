using apitest.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers;

[ApiController]
[Route("[controller]")]
public class FileSaveController : ControllerBase
     
{
    private readonly IFileSave _fileSave;

    

    public FileSaveController(IFileSave fileSave)
    {
        _fileSave = fileSave; 
    }

    [HttpGet(Name = "SaveFile")]
    public string SaveFile(string txt)
    {
        try
        {
            _fileSave.GetFileSaveAsync(txt);
            return "el archivo se guardó con éxito";
        }
        catch (Exception ex)
        {
            return "se presentó un error el archivo no se guardó con éxito";
            return ex.Message;

        }
            
      
    }
}

