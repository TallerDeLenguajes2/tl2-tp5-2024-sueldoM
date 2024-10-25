using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using SQLitePCL;

public class ProductosRepository{
    private string connectionString = "Data Source =../db/Tienda.db;Version=3";
    public void CrearProducto(Producto producto)
    {
        var query = @"INSERT INTO Productos (Descripcion, Precio) VALUES (@Descripcion, @Precio);";

        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = new SqliteCommand(query, connection);
            
            command.Parameters.Add(new SqliteParameter("@Descripcion", producto.Descripcion1));
            command.Parameters.Add(new SqliteParameter("@Precio", producto.Precio));
            command.ExecuteNonQuery();

            connection.Close();
            
        }
    }

    public List<Producto> ListarProductos()
    {
        var query = "SELECT * FROM Productos";
        List<Producto> productos = new List<Producto>();
        
        using(SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            SqliteCommand command = new SqliteCommand(query, connection);
            
            using(SqliteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    productos.Add(new Producto
                        (
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2)
                        )
                    );
                }
            }
        }
        return productos;
    }

    public Producto ObtenerProductoID(int id)
    {
        Producto? producto = null;
        using(SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Productos WHERE idProducto = id";
            using(SqliteCommand command = new SqliteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        producto = new Producto
                        (
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2)
                        );
                    }
                }
            }
        }
        return producto;
    }

    public void eliminarProducto(int id)
    {
        using(SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE * FROM Productos WHERE idProducto = id";
            using(SqliteCommand command = new SqliteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

            }
        }
    }
}