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
        private double costoKg;
        #endregion

        #region "Propiedades"
        public double CostoKg
        {
            get { return costoKg; }
            set { costoKg = value; }
        }
        #endregion

        #region "Costructor"
        public TwoDayPackage(string codigoR,string codigoD, string nombreR,
            string nombreD, string direccionR,string direccionD,
            string ciudadR, string ciudadD, string estadoDepartamentoR, string estadoDepartamentoD, string codigoPostalR, 
            string codigoPostalD, double peso)
            :base(codigoR,codigoD,nombreR,nombreD,direccionR,direccionD,ciudadR, ciudadD,estadoDepartamentoR,estadoDepartamentoD,codigoPostalR,codigoPostalD,peso)
        {
            this.costoKg                     = 100.0;
            this.codigoR                     = codigoR;
            this.codigoD                     = codigoD;
            this.nombreR                     = nombreR;
            this.nombreD                     = nombreD;
            this.direccionR                  = direccionR;
            this.direccionD                  = direccionD;
            this.ciudadR                     = ciudadR;
            this.ciudadD                     = ciudadD;
            this.estadoDepartamentoR         = estadoDepartamentoR;
            this.estadoDepartamentoD         = estadoDepartamentoD;
            this.codigoPostalR               = codigoPostalR;
            this.codigoPostalD               = codigoPostalD;
            this.peso                        = peso;
        }
        #endregion

            #region "Metos Sobre Escritos"
        public override string ToString()
        {
            return "\n_______________________________________________________________________" +
                   "\n___________________________Datos del Remitente_________________________"+
                   "\nIdentificacion:                   " + this.codigoR +
                   "\nNombres:                          " + this.nombreR +
                   "\nDireccion:                        " + this.direccionR +
                   "\nCiudada:                          " + this.ciudadR +
                   "\nEstado o Departamento:            " + this.estadoDepartamentoR +
                   "\nCodigo Postal del Remitente:      " + this.codigoPostalR +
                   "\n_______________________________________________________________________" +
                   "\n__________________________Datos de la rececror_________________________" +
                   "\nIdentificacion:                   " + this.codigoR +
                   "\nNombres:                          " + this.nombreR +
                   "\nDireccion:                        " + this.direccionR +
                   "\nCiudada:                          " + this.ciudadR +
                   "\nEstado o Departamento:            " + this.estadoDepartamentoR +
                   "\nCodigo Postal del Destinatario:   " + this.codigoPostalD +
                   "\n_______________________________________________________________________"+
                   "\n____________________________Datos del paqute___________________________"+
                   "\nPeso del paqute (Kg):             " + this.peso;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            TwoDayPackage p = (TwoDayPackage)obj;
            bool result = false;
            if ((this.codigoR == p.codigoR) &&
                (this.codigoD == p.codigoD) &&
                (this.nombreR == p.nombreR) &&
                (this.nombreD == p.nombreD) &&
                (this.direccionR == p.direccionR) &&
                (this.direccionD == p.direccionD) &&
                (this.ciudadR == p.ciudadR) &&
                (this.ciudadD == p.ciudadD) &&
                (this.estadoDepartamentoR == p.estadoDepartamentoR) &&
                (this.estadoDepartamentoD == p.estadoDepartamentoD) &&
                (this.codigoPostalR == p.codigoPostalR) &&
                (this.codigoPostalD == p.codigoPostalD)&&
                (this.peso == p.peso)&&
                (this.costoKg == p.costoKg))

            result = true;

        return result;
        }
        #endregion

        #region"Metodos"
        public void CalculateCosT()
        { 
            double pagar = this.peso * this.costoKg;
        }
        #endregion
    }
}