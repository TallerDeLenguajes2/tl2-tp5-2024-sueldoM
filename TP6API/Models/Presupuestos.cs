public class Presupuesto{
    private int idPresupuesto;
    private string? NombreDestinatario;
    private string? FechaCreacion;
    List<PresupuestoDetalle?> detalle;

    public Presupuesto(int idPresupuesto, string? nombreDestinatario, string? fechaCreacion, List<PresupuestoDetalle?> detalle)
    {
        this.idPresupuesto = idPresupuesto;
        NombreDestinatario = nombreDestinatario;
        FechaCreacion = fechaCreacion;
        this.detalle = detalle;
    }

    /*double montoPresupuesto(){

    }

    double montoPresupuestoConIVA(){

    }

    double cantidadProductos(){

    }*/

}