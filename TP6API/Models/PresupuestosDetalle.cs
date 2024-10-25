public class PresupuestoDetalle{
    Producto? producto;
    private int Cantidad;

    public PresupuestoDetalle(Producto? producto, int cantidad)
    {
        this.producto = producto;
        Cantidad = cantidad;
    }
}