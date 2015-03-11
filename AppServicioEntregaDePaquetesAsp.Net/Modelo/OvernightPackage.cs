using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetesAsp.Net.Modelo
{
    public class OvernightPackage : TwoDayPackage
    {
        #region "Atributos"
        private double cuota;
        #endregion

        #region "Propiedades"
        public double Cuata
        {
            get { return cuota; }
            set { cuota = value; }
        }
        #endregion

        #region "Costructor"
        public OvernightPackage(string codigoR, string codigoD, string nombreR, string nombreD, string direccionR, string direccionD,
            string ciudadR, string ciudadD, string estadoDepartamentoR, string estadoDepartamentoD, string codigoPostalR,
            string codigoPostalD, double peso, double costoKg,double pagar,double cuota)
            :base( codigoR,  codigoD,  nombreR,  nombreD,  direccionR,  direccionD, ciudadR,  ciudadD,  estadoDepartamentoR, 
            estadoDepartamentoD,  codigoPostalR,codigoPostalD,  peso,  costoKg, pagar)
        {
            this.costoKg                     = costoKg;
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
            this.Pagar                       = pagar;
            this.cuota                       = cuota;
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
                   "\n__________________________Datos de la rececror_________________________" +
                   "\nIdentificacion:                   " + this.codigoR +
                   "\nNombres:                          " + this.nombreR +
                   "\nDireccion:                        " + this.direccionR +
                   "\nCiudada:                          " + this.ciudadR +
                   "\nEstado o Departamento:            " + this.estadoDepartamentoR +
                   "\nCodigo Postal del Destinatario:   " + this.codigoPostalD +
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
                (this.peso == p.peso) &&
                (this.costoKg == p.costoKg)&&
                (this.pagar == p.pagar) &&
                (this.cuota == p.cuota))

            result = true;

        return result;
        }
        #endregion

        #region"Metodos"
        private void CalculateCost()
        { 
            if(this.pagar<=0){
                //Error
            }if(this.pagar>= 1.0 && this.pagar<5000.0) {
                this.cuota = this.pagar + 2000.0;
            }if (this.pagar >= 5000.0 && this.pagar < 12000.0) {
                this.cuota = this.pagar + 3000.0;
            }if (this.pagar >= 20000.0 && this.pagar < 40000.0) {
                this.cuota = this.pagar + 6000.0;
            }if (this.pagar >= 40000.0 && this.pagar < 80000.0) {
                this.cuota = this.pagar + 10000.0;
            }if (this.pagar >= 80000.0 && this.pagar < 100000.0) {
                this.cuota = this.pagar + 15000.0;
            } if (this.pagar > 100000.0) {
                this.cuota = this.pagar + 20000.0;
            }
        }
        #endregion
    }
}