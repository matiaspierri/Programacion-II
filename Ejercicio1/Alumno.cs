﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic;

using System.Windows.Forms;
namespace Ejercicio1
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int Edad { get; }

        public bool Activo { set; get; }

        public Alumno() { }

        public Alumno(int Legajo, string Nombre, string Apellido, int Edad,
                      DateTime FechaNacimiento, DateTime FechaIngreso,
                      bool Activo=true, int CantidadMateriasAprobadas=0, 
                      int CantidadMaterias=36): this()
        {
            this.Legajo = Legajo;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Activo = Activo;
            this.FechaNacimiento = FechaNacimiento;
            this.FechaIngreso = FechaIngreso;
            this.CantidadMateriasAprobadas = CantidadMateriasAprobadas;
        }




        private DateTime _fechasNacimiento;  // the name field
        public DateTime FechaNacimiento    // the Name property
        {
            get => _fechasNacimiento;
            set => _fechasNacimiento = value;
        }

        private DateTime _fechasIngreso;  // the name field
        public DateTime FechaIngreso    // the Name property
        {
            get => _fechasIngreso;
            set => _fechasIngreso = value;
        }

        private int _cantidadMateriasAprobadas;  // the name field
        public int CantidadMateriasAprobadas    // the Name property
        {
            get => _cantidadMateriasAprobadas;
            set => _cantidadMateriasAprobadas = value;
        }


        public void GetAntiguedad(EnumFormatoTiempo formatoTiempo)
        {
            long tiempo;
            
            if(formatoTiempo == EnumFormatoTiempo.formatoDia)
            {
                tiempo = DateAndTime.DateDiff(DateInterval.Day, this.FechaIngreso, DateTime.Now);
                MessageBox.Show($"La antiguedad es {tiempo} dias");

            }
            else if(formatoTiempo == EnumFormatoTiempo.formatoMes)
            {
                tiempo = DateAndTime.DateDiff(DateInterval.Month, this.FechaIngreso, DateTime.Now);
                MessageBox.Show($"La antiguedad es {tiempo} meses");

            }
            else
            {
                tiempo = DateAndTime.DateDiff(DateInterval.Year, this.FechaIngreso, DateTime.Now);
                MessageBox.Show($"La antiguedad es {tiempo} anio");


            }



        }

        // public int GetMateriasNoAprobadas() { }

        // public int GetEdadIngreso() { }


    }
}
