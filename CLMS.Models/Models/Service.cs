using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CLMS.Models
{
    class Service
    {
        public uint Id { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Define o valor do serviço prestado
        /// usar o comando abaixo para definir o tipo de "Dinheiro"
        /// <see cref="CultureInfo.CreateSpecificCulture()"/> para Definir a cultura que deve ser usada no programa. 
        /// </summary>
        /// <code>
        /// <c> WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));</c>
        /// </code>
        public decimal Value { get; set; }
        public decimal Penalty { get; set; }
    }
}
