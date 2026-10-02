using FeiradeProjetosApi.Models;

namespace FeiradeProjetosApi.Repository
{
    public class FeiradeProjetosRepository : IFeiradeProjetosRepository
    {
        private static readonly List<Projeto> ListaProjeto = new List<Projeto>();
        private static readonly List<Visita> ListaVisita = new List<Visita>();

        public void Cadastrar(Projeto projeto)
        {
            ListaProjeto.Add(projeto);
        }

        public Projeto ObterPorNumero(int numero)
        {
            return ListaProjeto.Where(a => a.NumeroProjeto == numero).FirstOrDefault();
        }

        public List<Projeto> ObterTodos()
        {
            return ListaProjeto;
        }

        public void RegistrarVisita(Visita visita)
        {
            ListaVisita.Add(visita);
        }

        public List<Visita> ObterVisitasPorProjeto(int numero)
        {
            return ListaVisita.Where(v => v.NumeroProjeto == numero).ToList();
        }
    }
}