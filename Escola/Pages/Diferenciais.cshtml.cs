using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Escola.Pages
{
    public class DiferenciaisModel : PageModel
    {
        public List<Professor> x { get; set; } = new List<Professor>();
        public void OnGet()
        {
            x = new List<Professor>
    {
        new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/Deadpool_&_Wolverine_cartaz.jpg"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/DivertidaMente2.jpeg"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/MeuMalvadoFavorito 4.jpg"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/OCorvo.webp"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/HellBoyeoHomemTorto.webp"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
            },
            new Professor
            {
                Descricao = "",
                ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
            },

        };
        }
    }
}
    