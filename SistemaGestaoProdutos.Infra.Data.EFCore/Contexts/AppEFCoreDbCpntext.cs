using Microsoft.EntityFrameworkCore;
using SistemaGestaoProdutos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos.Infra.Data.EFCore.Contexts
{
    public class AppEFCoreDbCpntext : DbContext
    {
        public AppEFCoreDbCpntext(DbContextOptions<AppEFCoreDbCpntext> options) : base (options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
