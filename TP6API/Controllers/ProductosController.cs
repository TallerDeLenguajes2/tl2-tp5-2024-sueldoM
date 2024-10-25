using Microsoft.AspNetCore.Mvc;

namespace TP6API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductosController: ControllerBase
{
    public ProductosController(ILogger<ProductosController> logger){
        
    }
}