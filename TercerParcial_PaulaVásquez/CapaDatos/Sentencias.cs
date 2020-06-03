using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Sentencias
    {

        Conexion cn = new Conexion();
        OdbcCommand comm;
        //----------------------------------------------------INSERTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar1(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into vendedores values(" + uno + ", '" + dos + "' ,'" + tres + "','" + cuatro + "' ,'" + cinco + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- MODIFICAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar1(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE vendedores set nombre_vendedor='" + dos + "',direccion_vendedor='" + tres + "',telefono_vendedor='" + cuatro + "',nit_vendedor='" + cinco + "',estatus_vendedor='" + sestado + "' where codigo_vendedor='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- ELIMINAR UNO -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar1(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE vendedores set estatus_vendedor ='0' where codigo_vendedor='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- CONSULTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta1(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from vendedores where estatus_vendedor = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //----------------------------------------------------INSERTAR DOS ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar2(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into marcas values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR DOS ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar2(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE marcas set nombre_marca='" + dos + "',estatus_marca='" + sestado + "' where codigo_marca='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- ELIMINAR DOS -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar2(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE marcas set estatus_marca ='0' where codigo_marca='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- CONSULTAR DOS ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta2(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from marcas  where estatus_marca = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //----------------------------------------------------INSERTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar3(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into lineas values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar3(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE lineas set nombre_linea='" + dos + "',estatus_linea='" + sestado + "' where codigo_curso='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- ELIMINAR TRES -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar3(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE lineas set estatus_linea ='0' where codigo_linea='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- CONSULTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta3(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from lineas where estatus_linea = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
            //------------------------------------------------------------------------------------------------------------------------------------------------------------
            //CUATRO
            //----------------------------------------------------INSERTAR TRES ------------------------------------------------------------------------------------------
            public OdbcDataReader guardar4(string uno, string dos, string sestado)
            {
                try
                {
                    cn.conexionbd();
                    string consulta = "insert into bodegas values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                    comm = new OdbcCommand(consulta, cn.conexionbd());
                    OdbcDataReader mostrar = comm.ExecuteReader();
                    return mostrar;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return null;
                }
            }

            //--------------------------------------------------- MODIFICAR TRES ------------------------------------------------------------------------------------------
            public OdbcDataReader modificar4(string uno, string dos, string sestado)
            {
                try
                {
                    cn.conexionbd();
                    string consulta = "UPDATE bodegas set nombre_bodega='" + dos + "',estatus_bodega='" + sestado + "' where codigo_bodega='" + uno + "';";
                    comm = new OdbcCommand(consulta, cn.conexionbd());
                    OdbcDataReader mostrar = comm.ExecuteReader();
                    return mostrar;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return null;
                }
            }

            //--------------------------------------------------- ELIMINAR TRES -------------------------------------------------------------------------------------------
            public OdbcDataReader eliminar4(string uno)
            {
                try
                {
                    cn.conexionbd();
                    string consulta = "UPDATE bodegas set estatus_bodega ='0' where codigo_bodega='" + uno + "';";
                    comm = new OdbcCommand(consulta, cn.conexionbd());
                    OdbcDataReader mostrar = comm.ExecuteReader();
                    return mostrar;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return null;
                }
            }

        //--------------------------------------------------- CONSULTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta4(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from bodegas where estatus_bodega = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------INSERTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar5(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into proveedores values(" + uno + ", '" + dos + "' ,'" + tres + "','" + cuatro + "' ,'" + cinco + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- MODIFICAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar5(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedores set nombre_proveedor='" + dos + "',direccion_proveedor='" + tres + "',telefono_proveedor='" + cuatro + "',nit_proveedor='" + cinco + "',estatus_proveedor='" + sestado + "' where codigo_proveedor='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- ELIMINAR UNO -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar5(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedores set estatus_proveedor ='0' where codigo_proveedor='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- CONSULTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta5(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from proveedores where estatus_proveedor = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------INSERTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar6(string uno, string dos, string tres, string cuatro, string cinco, string seis, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into clientes values(" + uno + ", '" + dos + "' ,'" + tres + "','" + cuatro + "' ,'" + cinco + "' ,'" + seis + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- MODIFICAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar6(string uno, string dos, string tres, string cuatro, string cinco,string seis, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE clientes set nombre_cliente='" + dos + "',direccion_cliente='" + tres + "',nit_cliente='" + cuatro + "',telefono_cliente='" + cinco + "',codigo_vendedor='" + seis + "',estatus_cliente='" + sestado + "' where codigo_cliente='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- ELIMINAR UNO -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar6(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE clientes set estatus_cliente ='0' where codigo_cliente='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- CONSULTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta6(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from clientes where estatus_cliente = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        //----------------------------------------------------INSERTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar7(string uno, string dos, string tres, string cuatro, float cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into productos values(" + uno + ", '" + dos + "' ,'" + tres + "','" + cuatro + "' ,'" + cinco + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- MODIFICAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar7(string uno, string dos, string tres, string cuatro, float cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productos set nombre_producto='" + dos + "',codigo_linea='" + tres + "',codigo_marca='" + cuatro + "',existencia_producto='" + cinco + "',estatus_producto='" + sestado + "' where codigo_producto='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- ELIMINAR UNO -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar7(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productos set estatus_producto ='0' where codigo_producto='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- CONSULTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta7(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from productos where estatus_producto = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        //----------------------------------------------------INSERTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar8(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into vendedores values(" + uno + ", '" + dos + "' ,'" + tres + "','" + cuatro + "' ,'" + cinco + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- MODIFICAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar8(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE vendedores set nombre_vendedor='" + dos + "',direccion_vendedor='" + tres + "',telefono_vendedor='" + cuatro + "',nit_vendedor='" + cinco + "',estatus_vendedor='" + sestado + "' where codigo_vendedor='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- ELIMINAR UNO -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar8(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE vendedores set estatus_vendedor ='0' where codigo_vendedor='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- CONSULTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta8(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from vendedores where estatus_vendedor = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        //***********************
        public OdbcDataReader guardar9(string uno, string dos, string tres, float cuatro, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into ventas_encabezado values(" + uno + ", '" + dos + "' ,'" + tres + "','" + cuatro + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- MODIFICAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar9(string uno, string dos, string tres, float cuatro,  string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE ventas_encabezado set codigo_cliente ='" + dos + "',fecha_ventaenca='" + tres + "',total_ventaenca='" + cuatro + "',estatus_ventaenca='" + sestado + "' where documento_ventaenca='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- ELIMINAR UNO -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar9(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE ventas_encabezado set estatus_ventaenca ='0' where documento_ventaenca='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consulta9(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from ventas_encabezado where estatus_ventaenca = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader guardar15(string uno, string dos, float sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into existencias values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR DOS ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar15(string uno, string dos, float sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE existencias set codigo_producto='" + dos + "',saldo_existencia='" + sestado + "' where codigo_bodega='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consulta15(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from existencias ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

    }
}


