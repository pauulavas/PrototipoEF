using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Logica
    {
        Sentencias sn = new Sentencias();

        public OdbcDataReader guardar1(string uno, string dos, string tres, string cuatro, string cinco, string estado)
        {
            return sn.guardar1(uno, dos, tres, cuatro, cinco, estado);

        }

        public OdbcDataReader modificar1(string uno, string dos, string tres, string cuatro, string cinco, string estado)
        {
            return sn.modificar1(uno, dos, tres, cuatro, cinco, estado);

        }

        public OdbcDataReader eliminar1(string uno)
        {
            return sn.eliminar1(uno);

        }

        public OdbcDataReader consulta1(string numero)
        {
            return sn.consulta1(numero);
        }
        //-------------------- DOS
        public OdbcDataReader guardar2(string uno, string dos, string estado)
        {
            return sn.guardar2(uno, dos,  estado);

        }

        public OdbcDataReader modificar2(string uno, string dos,  string estado)
        {
            return sn.modificar2(uno, dos,  estado);

        }

        public OdbcDataReader eliminar2(string uno)
        {
            return sn.eliminar2(uno);

        }

        public OdbcDataReader consulta2(string numero)
        {
            return sn.consulta2(numero);
        }
        //---------tres
        public OdbcDataReader guardar3(string uno, string dos, string estado)
        {
            return sn.guardar3(uno, dos, estado);

        }

        public OdbcDataReader modificar3(string uno, string dos, string estado)
        {
            return sn.modificar3(uno, dos, estado);

        }

        public OdbcDataReader eliminar3(string uno)
        {
            return sn.eliminar3(uno);

        }

        public OdbcDataReader consulta3(string numero)
        {
            return sn.consulta3(numero);
        }
        //-----CUATRO
        public OdbcDataReader guardar4(string uno, string dos, string estado)
        {
            return sn.guardar4(uno, dos, estado);

        }

        public OdbcDataReader modificar4(string uno, string dos, string estado)
        {
            return sn.modificar4(uno, dos, estado);

        }

        public OdbcDataReader eliminar4(string uno)
        {
            return sn.eliminar4(uno);

        }

        public OdbcDataReader consulta4(string numero)
        {
            return sn.consulta4(numero);
        }
        //-----CINCO
        public OdbcDataReader guardar5(string uno, string dos, string tres, string cuatro, string cinco,  string estado)
        {
            return sn.guardar5(uno, dos, tres, cuatro, cinco,estado);

        }

        public OdbcDataReader modificar5(string uno, string dos, string tres, string cuatro, string cinco, string estado)
        {
            return sn.modificar5(uno, dos, tres, cuatro, cinco, estado);

        }

        public OdbcDataReader eliminar5(string uno)
        {
            return sn.eliminar5(uno);

        }

        public OdbcDataReader consulta5(string numero)
        {
            return sn.consulta5(numero);
        }

        //-----SEIS
        public OdbcDataReader guardar6(string uno, string dos, string tres, string cuatro, string cinco,string seis, string estado)
        {
            return sn.guardar6(uno, dos, tres, cuatro, cinco,seis, estado);

        }

        public OdbcDataReader modificar6(string uno, string dos, string tres, string cuatro, string cinco, string seis, string estado)
        {
            return sn.modificar6(uno, dos, tres, cuatro, cinco,seis, estado);

        }

        public OdbcDataReader eliminar6(string uno)
        {
            return sn.eliminar6(uno);

        }

        public OdbcDataReader consulta6(string numero)
        {
            return sn.consulta6(numero);
        }
        //-----SIETE
        public OdbcDataReader guardar7(string uno, string dos, string tres, string cuatro, float cinco, string estado)
        {

            return sn.guardar7(uno, dos, tres, cuatro, cinco,  estado);
        }

        public OdbcDataReader modificar7(string uno, string dos, string tres, string cuatro, float cinco, string estado)
        {
            return sn.modificar7(uno, dos, tres, cuatro, cinco,  estado);

        }

        public OdbcDataReader eliminar7(string uno)
        {
            return sn.eliminar7(uno);

        }

        public OdbcDataReader consulta7(string numero)
        {
            return sn.consulta7(numero);
        }

        //-----OCHO
        /*
        public OdbcDataReader guardar8(string uno, string dos, string tres, string estado)
        {
            return sn.guardar8(uno, dos, tres, estado);

        }

        public OdbcDataReader modificar8(string uno, string dos,string tres, string estado)
        {
            return sn.modificar8(uno, dos, tres, estado);

        }

        public OdbcDataReader eliminar8(string uno)
        {
            return sn.eliminar8(uno);

        }

        public OdbcDataReader consulta8(string numero)
        {
            return sn.consulta8(numero);
        }
      */

    }
}
