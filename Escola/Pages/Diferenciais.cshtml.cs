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
    Descricao = "Especialista em Segurança Cibernética e Proteção de Dados",
    ImagemUrl = "C:\\Users\\62127702024.2\\Documents\\GitHub\\Escola\\Escola\\wwwroot\\Imagens\\beard-1845166_1280.jpg"
},
new Professor
{
    Descricao = "Especialista em Inteligência Artificial e Machine Learning",
    ImagemUrl = "/images/"
},
new Professor
{
    Descricao = "Desenvolvedor de Software e Arquitetura de Sistemas",
    ImagemUrl = "/images/MeuMalvadoFavorito 4.jpg"
},
new Professor
{
    Descricao = "Consultor em Infraestrutura de TI e Redes",
    ImagemUrl = "/images/OCorvo.webp"
},
new Professor
{
    Descricao = "Engenheiro de Dados e Análise de Big Data",
    ImagemUrl = "/images/HellBoyeoHomemTorto.webp"
},
new Professor
{
    Descricao = "Especialista em Desenvolvimento de Aplicações Móveis",
    ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
},
new Professor
{
    Descricao = "Analista de Sistemas e Gerenciamento de Projetos de TI",
    ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
},
new Professor
{
    Descricao = "Especialista em Usabilidade e Design de Interfaces",
    ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
},
new Professor
{
    Descricao = "Consultor em Transformação Digital e Inovação Tecnológica",
    ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
}



        };
        }
    }
}
    