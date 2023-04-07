using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Cadastro_Produtos.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCompra { get; set; }
        public float Estoque { get; set; }

    }
}