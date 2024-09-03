using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;

namespace LojaVirtual.Repositories
{
    public class NewsletterRepository : INewsletterRepository
    {
        public LojaVirtualContext _banco;
        public NewsletterRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }
        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.NewsletterEmails.Add(newsletter);
            _banco.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> ObterTodasNewsletter()
        {
            return _banco.NewsletterEmails.ToList();
        }
    }
}
