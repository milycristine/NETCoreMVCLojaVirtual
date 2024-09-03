using LojaVirtual.Models;

namespace LojaVirtual.Repositories.Contracts
{
    public interface INewsletterRepository
    {
        void Cadastrar(NewsletterEmail newsletter);

        IEnumerable<NewsletterEmail> ObterTodasNewsletter();

    }
}
