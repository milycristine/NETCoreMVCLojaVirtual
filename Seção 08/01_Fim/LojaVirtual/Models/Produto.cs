﻿namespace LojaVirtual.Models
{
    public class Produto
    {
        //pk
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
