using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAccessLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string StreetAddress { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string State { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")] //Aqui eu to deixando meu banco mais eficiente, em termos de performance, porque um numero postal nao precisa ser UNICODE, nao tem razão pra armazenar 2Bytes por caractere, pq vai ser basicamente numeros de 0 a 9, no maximo com caracteres como ' - e . '.
        public string ZipCode { get; set; }
    }
}
