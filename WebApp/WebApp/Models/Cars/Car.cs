using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    // Класс, представляющий запись в таблице Машины
    public partial class Car
    {
        [Key]
        public int Id { get; set; }
        public string Carbrands { get; set; }
        public string Numberofthecar { get; set; }
        public int OwnersId { get; set; }
    }
}
