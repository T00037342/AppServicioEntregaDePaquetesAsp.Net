using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquetesAsp.Net.Modelos
{
    public class Package
    {
        #region "Atributos"

        public string codigo;
        public string nombre;
        public string direccion;
        public string ciudad;
        public string estadoDepartamento;
        public string codigoPostalR;
        public string codigoPostalD;
        public double peso;

        #endregion

        #region "Propiedades"

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string EstadoDepartamento
        {
            get { return estadoDepartamento; }
            set { estadoDepartamento = value; }
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
        public Package(string codigo, string nombre, string direccion, string ciudad, string estadoDepartamento, string codigoPostalR, string codigoPostalD, double peso)
        {
            this.codigo              = codigo;
            this.nombre              = nombre;
            this.direccion           = direccion;
            this.ciudad              = ciudad;
            this.estadoDepartamento  = estadoDepartamento;
            this.codigoPostalR       = codigoPostalR;
            this.codigoPostalD       = codigoPostalD;
            this.peso                = peso;
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
                (this.peso == p.peso))

            result = true;

        return result;
        }
        #endregion

    }
}