using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    // Класс, представляющий запись в таблице Владельцы
    public partial class Owner
    {
        [Key]
        public int Id { get; set; }
        public string Fio { get; set; }
        public string NameFone { get; set; }
    }
}
