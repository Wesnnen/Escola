using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Escola.Pages
{
    public class contatoModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Mensagem { get; set; }

        public bool MensagemEnviada { get; set; }

        public void OnPost()
        {
            // Simular o envio da mensagem
            MensagemEnviada = true;
        }
    }
}
