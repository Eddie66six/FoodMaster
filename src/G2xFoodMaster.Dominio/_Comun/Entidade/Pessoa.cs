using System;

namespace G2xFoodMaster.Dominio._Comun.Entidade
{
    public class Pessoa : Base
    {
        public string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }
        public int ObterIdade()
        {
            return DateTime.Today.Year - DataDeNascimento.Date.Year;
        }

        #region attr
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        public string Apelido { get; protected set; }
        public DateTime DataDeNascimento { get; protected set; }
        public virtual Login Login { get; protected set; }
        public string Cep { get; protected set; }
        public string Rua { get; protected set; }
        public string Bairro { get; protected set; }
        public string Cidade { get; protected set; }
        public string Numero { get; protected set; }
        public string Complemento { get; protected set; }
        public string Referencia { get; set; }
        #endregion
    }
}
