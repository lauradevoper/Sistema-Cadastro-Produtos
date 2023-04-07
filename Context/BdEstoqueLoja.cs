using Sistema_Cadastro_Produtos.Models;
using System;
using System.Data.Entity;

namespace Sistema_Cadastro_Produtos.Context
{
    public class BdEstoqueLoja : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

       
    }
}