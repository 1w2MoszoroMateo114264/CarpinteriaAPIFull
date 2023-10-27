using CarpinteriaBack.Datos.Implementaciones;
using CarpinteriaBack.Datos.Interfaz;
using CarpinteriaBack.Entidades;
using CarpinteriaBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IPresupuestoDao dao;
        public Aplicacion()
        {
            dao = new PresupuestoDao();
        }
        public bool SavePresupuesto(Presupuesto oPresupuesto)
        {
            return dao.Crear(oPresupuesto);
        }

        public List<Producto> GetProductos()
        {
            return dao.ObtenerProductos();
        }
    }
}
