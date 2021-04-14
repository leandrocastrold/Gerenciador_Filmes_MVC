using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Series.Web.Enums
{
    public enum Genero
    {
        [Display(Name = "Ação")]
        ACAO,
        [Display(Name = "Aventura")]
        AVENTURA,
        [Display(Name = "Animação")]
        ANIMACAO,
        [Display(Name = "Terror")]
        TERROR,
        [Display(Name = "Suspense")]
        SUSPENSE,
        [Display(Name = "Drama")]
        DRAMA,
        [Display(Name = "Romantico")]
        ROMANTICO
    }
}
