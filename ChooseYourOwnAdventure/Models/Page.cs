using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure.Models
{
    public class Page
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Story))]
        public int StoryId { get; set; }
        public Story Story { get; set; }
       
        string Text { get; set; }

        //public virtual Option FromOpt { get; set; }
    }
}
