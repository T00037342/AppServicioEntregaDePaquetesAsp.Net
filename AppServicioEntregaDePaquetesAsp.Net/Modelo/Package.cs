using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetesAsp.Net.Modelos
{
    public class Package
    {
        #region "Atributos"

        public string codigoR;
        public string codigoD;
        public string nombreR;
        public string nombreD;
        public string direccionR;
        public string direccionD;
        public string ciudadR;
        public string ciudadD;
        public string estadoDepartamentoR;
        public string estadoDepartamentoD;
        public string codigoPostalR;
        public string codigoPostalD;
        public double peso;

        #endregion

        #region "Propiedades"

        public string CodigoR
        {
            get { return codigoR; }
            set { codigoR = value; }
        }
        public string CodigoD
        {
            get { return codigoD; }
            set { codigoD = value; }
        }
        public string NombreR
        {
            get { return nombreR; }
            set { nombreR = value; }
        }
        public string NombreD
        {
            get { return nombreD; }
            set { nombreD = value; }
        }
        public string DireccionR
        {
            get { return direccionR; }
            set { direccionR = value; }
        }
        public string DireccionD
        {
            get { return direccionD; }
            set { direccionD = value; }
        }
        public string CiudadR
        {
            get { return ciudadR; }
            set { ciudadR = value; }
        }
        public string CiudadD
        {
            get { return ciudadD; }
            set { ciudadD = value; }
        }
        public string EstadoDepartamentoR
        {
            get { return estadoDepartamentoR; }
            set { estadoDepartamentoR = value; }
        }
        public string EstadoDepartamentoD
        {
            get { return estadoDepartamentoD; }
            set { estadoDepartamentoD = value; }
        }
        public string CodigoPostalR
        {
            get { return codigoPostalR; }
            set { codigoPostalR = value; }
        }
        public string CodigoPostalD
        {
            get { return codigoPostalD; }
            set { codigoPostalD = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        #endregion

        #region "Costructor"
        public Package(string codigoR,string codigoD, string nombreR, string nombreD, string direccionR,string direccionD,
            string ciudadR, string ciudadD, string estadoDepartamentoR, string estadoDepartamentoD, string codigoPostalR, 
            string codigoPostalD, double peso)
        {
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
            Package p = (Package)obj;
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
                (this.peso == p.peso))

            result = true;

        return result;
        }
        #endregion

    }
}