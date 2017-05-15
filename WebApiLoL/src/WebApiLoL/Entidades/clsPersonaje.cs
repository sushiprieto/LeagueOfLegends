﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLoL.Entidades
{
    public class clsPersonaje
    {
        //Constructor por defecto

        public clsPersonaje()
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

        //Constructor por parámetros

        public clsPersonaje(string nombre, string alias, double vida, double regeneracion, double danno, double armadura, double velAtaque, double resistencia, double velMovimiento)
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
    }
}
