﻿using System.Collections.Generic;

namespace G2xFoodMaster.Dominio.Estabelecimento.Entidade
{
    public class Estabelecimento
    {
        protected Estabelecimento()
        {
            
        }

        public Estabelecimento(string nome)
        {
            Nome = nome;
        }

        public int IdEstabelecimento { get; protected set; }
        public string Nome { get; protected set; }
        public virtual List<Filial> Filiais { get; protected set; }
    }
}