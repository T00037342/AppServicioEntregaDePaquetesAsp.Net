using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetesAsp.Net.Datos
{
    public class TwoDayPackage : Package
    {
        #region "Atributos"
        private double calculateCost;
        #endregion

        #region "Propiedades"
        public double CalculateCost
        {
            get { return calculateCost; }
            set { calculateCost = value; }
        }
        #endregion

        #region "Costructor"
        
        public TwoDayPackage(string codigo, string nombre, string direccion, string ciudad, string estadoDepartamento, string codigoPostalR, string codigoPostalD, double peso)
        :base( codigo,  nombre,  direccion,  ciudad,  estadoDepartamento,  codigoPostalR,  codigoPostalD,  peso)
        {
            this.calculateCost=0.0;
            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.estadoDepartamento = estadoDepartamento;
            this.codigoPostalR = codigoPostalR;
            this.codigoPostalD = codigoPostalD;
            this.peso = peso;
        }

        #endregion

        #region "Metos Sobre Escritos"
         public override string ToString()
        {
            return "\n___________________________________________________________________" +
                   "\nIdentificacion:                   " + this.codigo +
                   "\nNombres:                          " + this.nombre +
                   "\nDireccion:                        " + this.direccion +
                   "\nCiudada:                          " + this.ciudad +
                   "\nEstado o Departamento:            " + this.estadoDepartamento +
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
            if ((this.codigo == p.codigo) &&
                (this.nombre == p.nombre) &&
                (this.direccion == p.direccion) &&
                (this.ciudad == p.ciudad) &&
                (this.estadoDepartamento == p.estadoDepartamento) &&
                (this.codigoPostalR == p.codigoPostalR) &&
                (this.codigoPostalD == p.codigoPostalD)&&
                (this.peso == p.peso)&&
                (this.calculateCost == p.calculateCost))

            result = true;

        return result;
        }
        #endregion
    }
}