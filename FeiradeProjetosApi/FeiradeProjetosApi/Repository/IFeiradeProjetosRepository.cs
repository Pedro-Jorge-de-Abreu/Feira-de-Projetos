using FeiradeProjetosApi.Models;

namespace FeiradeProjetosApi.Repository
{
    public interface IFeiradeProjetosRepository
    {
        public void Cadastrar(Projeto projeto);
        public List<Projeto> ObterTodos();
        public Projeto ObterPorNumero(int numero);
        public void RegistrarVisita(Visita visita);
        public List<Visita> ObterVisitasPorProjeto(int numero);
    }
}