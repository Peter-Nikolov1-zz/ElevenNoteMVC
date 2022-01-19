using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter more than 2 characters.")]
        [MaxLength(40, ErrorMessage ="Please delete some of your title!")]
        public string Title { get; set; }

        [MaxLength(5000)]
        public string Content { get; set; }
    }
}
