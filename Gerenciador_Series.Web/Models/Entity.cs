using Gerenciador_Series.Web.Enums;
using System;

namespace Gerenciador_Series.Web.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}
