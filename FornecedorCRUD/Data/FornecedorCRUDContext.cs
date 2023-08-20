using FornecedorCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace FornecedorCRUD.Data
{
    public class FornecedorCRUDContext : DbContext
    {
        public DbSet<Fornecedor> fornecedores { get; set; }
        public FornecedorCRUDContext(DbContextOptions<FornecedorCRUDContext> options) 
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
