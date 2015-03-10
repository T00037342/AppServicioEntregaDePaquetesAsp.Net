using AppServicioEntregaDePaquetesAsp.Net.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetesAsp.Net.Modelo
{
    public class TwoDayPackage : Package
    {
        #region "Atributos"
        private static double calculateCosT=0;
        #endregion

        #region "Propiedades"
        public double CalculateCosT
        {
            get { return calculateCosT; }
            set { calculateCosT = value; }
        }
        #endregion

        #region "Costructor"
        
        public TwoDayPackage(string codigo, string nombre, string direccion, string ciudad, string estadoDepartamento, string codigoPostalR, string codigoPostalD, double peso)
        :base( codigo,  nombre,  direccion,  ciudad,  estadoDepartamento,  codigoPostalR,  codigoPostalD,  peso)
        {
            this.codigoR = codigo;
            this.nombreR = nombre;
            this.direccionR = direccion;
            this.ciudadR = ciudad;
            this.estadoDepartamentoR = estadoDepartamento;
            this.codigoPostalR = codigoPostalR;
            this.codigoPostalD = codigoPostalD;
            this.peso = peso;
        }

        #endregion

        #region "Metos Sobre Escritos"
         public override string ToString()
        {
            return "\n___________________________________________________________________" +
                   "\nIdentificacion:                   " + this.codigoR +
                   "\nNombres:                          " + this.nombreR +
                   "\nDireccion:                        " + this.direccionR +
                   "\nCiudada:                          " + this.ciudadR +
                   "\nEstado o Departamento:            " + this.estadoDepartamentoR +
                   "\nCodigo Postal del Remitente:      " + this.codigoPostalR +
                   "\nCodigo Postal del Destinatario:   " + this.codigoPostalD +
                   "\nPeso del paqute (Kg):             " + this.peso +
                   "\n__________________________________________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Package p = (Package)obj;
            bool result = false;
            if ((this.nombreR == p.nombreR) &&
                (this.direccionR == p.direccionR) &&
                (this.ciudadR == p.ciudadR) &&
                (this.estadoDepartamentoR == p.estadoDepartamentoR) &&
                (this.codigoPostalR == p.codigoPostalR) &&
                (this.codigoPostalD == p.codigoPostalD) &&
                (this.peso == p.peso) &&
                (this.codigoR == p.codigoR)) 

            result = true;

        return result;
        }
        #endregion
    }
}