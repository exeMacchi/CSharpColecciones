using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_01
{
    class Componente
    {
        public Componente(string codigoReferencia, string categoria, string marca, 
                          string modelo, float precio)
        {
            this.codigoReferencia = codigoReferencia;
            this.categoria = categoria;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }

        private string codigoReferencia;
        private string categoria;
        private string marca;
        private string modelo;
        private float precio;

        public string Categoria { get { return categoria; } }

        public override string ToString()
        {
            return ($"[{codigoReferencia}] - {categoria} - {marca} - {modelo} - " +
                    $"${precio.ToString("#.##")}");
        }
    }
}
