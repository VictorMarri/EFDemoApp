using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLibrary.DataAccess
{
    public class PeopleContext : DbContext
    {
        /// <summary>
        /// Esse construtor aqui, nos dá a opção de termos um construtor nessa classe, caso precisemos
        /// E tambem nos da a possibilidade de podermos chamar o construtor base com essas opções (options) que passamos aqui abaixo
        /// </summary>
        /// <param name="options"></param>
        public PeopleContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Aqui abaixo consiste no processo de criarmos nossas tabelas
        /// A gente tem que se atentar geralmente em nomear esse atributo no plural
        /// Com isso aqui, teremos 3 tabelas
        /// </summary>
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAdresses { get; set; }

    }
}
