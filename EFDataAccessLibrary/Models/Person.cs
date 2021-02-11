using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLibrary.Models
{
    public class Person
    {
        /// <summary>
        /// A gente tem uma Pessoa, e uma pessoa tem Primeiro nome, um sobrenome e uma idade.
        /// Essa pessoa tem uma lista de Endereços, porque, uma pessoa pode residir em mais de um local
        /// Essa pessoa tem a possibilidade de ter varios endereços de emails, por isso será uma lista
        /// É importante antes de lançar seu projeto, se perguntar se realmente não existe a possibilidade de uma entidade não ter varios registros de alguma coisa, como aqui por exemplo, varios registros de email ou endereços.
        /// </summary>
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public int LastName { get; set; }
        [Required]
        public int Age { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Email> EmailAdresses { get; set; } = new List<Email>();
    }
}
