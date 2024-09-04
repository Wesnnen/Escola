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
    Descricao = "Especialista em Seguran�a Cibern�tica e Prote��o de Dados",
    ImagemUrl = "C:\\Users\\62127702024.2\\Documents\\GitHub\\Escola\\Escola\\wwwroot\\Imagens\\beard-1845166_1280.jpg"
},
new Professor
{
    Descricao = "Especialista em Intelig�ncia Artificial e Machine Learning",
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
    Descricao = "Engenheiro de Dados e An�lise de Big Data",
    ImagemUrl = "/images/HellBoyeoHomemTorto.webp"
},
new Professor
{
    Descricao = "Especialista em Desenvolvimento de Aplica��es M�veis",
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
    Descricao = "Consultor em Transforma��o Digital e Inova��o Tecnol�gica",
    ImagemUrl = "/images/LuccaseGiemDinossauros.jpg"
}



        };
        }
    }
}
    