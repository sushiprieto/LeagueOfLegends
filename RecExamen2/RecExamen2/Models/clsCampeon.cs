using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecExamen2.Models
{
    public class clsCampeon
    {

        #region Atributos

        public int idPersonaje { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public double vida { get; set; }
        public double regeneracion { get; set; }
        public double danno { get; set; }
        public double armadura { get; set; }
        public double velAtaque { get; set; }
        public double resistencia { get; set; }
        public double velMovimiento { get; set; }
        public string foto { get; set; }
        public ObservableCollection<Uri> skins { get; set; }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public clsCampeon()
        {
            this.nombre = "";
            this.alias = "";
            this.vida = 0;
            this.regeneracion = 0;
            this.danno = 0;
            this.armadura = 0;
            this.velAtaque = 0;
            this.resistencia = 0;
            this.velMovimiento = 0;
        }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="alias"></param>
        /// <param name="vida"></param>
        /// <param name="regeneracion"></param>
        /// <param name="danno"></param>
        /// <param name="armadura"></param>
        /// <param name="velAtaque"></param>
        /// <param name="resistencia"></param>
        /// <param name="velMovimiento"></param>
        public clsCampeon(string nombre, string alias, double vida, double regeneracion, double danno, double armadura, double velAtaque, double resistencia, double velMovimiento)
        {
            this.nombre = nombre;
            this.alias = alias;
            this.vida = vida;
            this.regeneracion = regeneracion;
            this.danno = danno;
            this.armadura = armadura;
            this.velAtaque = velAtaque;
            this.resistencia = resistencia;
            this.velMovimiento = velMovimiento;         
        }

        #endregion

    }
}
