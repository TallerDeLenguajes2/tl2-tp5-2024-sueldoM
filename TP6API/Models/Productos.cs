public class Producto{
    private int idProducto;
    private string? Descripcion;
    private int precio;

    public int IdProducto { get => idProducto; set => idProducto = value; }

    public string? Descripcion1 => Descripcion;

    public int Precio { get => precio; set => precio = value; }

    public Producto(int idProducto, string? descripcion, int precio)
    {
        this.IdProducto = idProducto;
        Descripcion = descripcion;
        this.Precio = precio;
    }
}

