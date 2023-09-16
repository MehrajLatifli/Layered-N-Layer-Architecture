using System.ComponentModel.DataAnnotations;

namespace Radio_player.Mapper
{
    public class RadioDTO
    {
        [Required]
        public string RadioName { get; set; }

        [Required]
        public string ImageRadio { get; set; }

        [Required]
        public string RadioFile { get; set; }

        [Required]
        public string RadioCountry { get; set; }
    }
}