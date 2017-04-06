namespace G2xFoodMaster.Dominio.Estabelecimento.Entidade
{
    public class Filial
    {
        public int IdFilial { get; protected set; }
        public string Nome { get; protected set; }
        public int IdEstabelecimento { get; protected set; }
        public virtual Estabelecimento Estabelecimento { get; protected set; }
    }
}