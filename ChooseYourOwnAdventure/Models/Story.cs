using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure.Models
{
    public class Story
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public Account User { get; set; }
        public string Title { get; set; }

        public virtual List<Page> Pages { get; set; }
    }
}
