﻿using Gerenciador_Series.Web.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciador_Series.Web.Models
{
    public class Serie : Entity
    {
        public int NumEpisodios { get; set; }
        public int CategoriaID { get; set; }

        [ForeignKey(nameof(CategoriaID))]
        public virtual Categoria Categoria { get; set; }
    }
}
