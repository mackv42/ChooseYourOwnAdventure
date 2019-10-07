using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(BelongsTo))]
        public int PageId { get; set; }
        public Page BelongsTo { get; set; }

        public string Opt { get; set; }
        [ForeignKey(nameof(OptResult))]
        public int OptResultId { get; set; }
        public Page OptResult { get; set; }
    }
}
