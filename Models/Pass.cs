using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymUsers.Models
{
    public class Pass
    {
        [Key] public int Id { get; set; }

        //date of buting pass
        [Required(ErrorMessage ="Nalezy wybrac date wykupienia karnetu")]
        [DisplayName("Data wykupienia karnetu")] 

        public DateTime StartPass { get; set; }

        //entry quantity
        [Required(ErrorMessage ="Nalezy podac ilosc wykupionych wejsc")]
        [DisplayName("Ilosc wykupionych wejsc")] 
        
        public int EtryQuantity { get; set; }

        //user

        [Required]
        [ForeignKey("Users")]
        [DisplayName("ID kupujacego")]
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
