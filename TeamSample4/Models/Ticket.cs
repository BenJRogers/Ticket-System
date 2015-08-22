using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TeamSample4.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }



        [Required]
        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Author")]
        public string Author { get; set; }

        [Display(Name = "Assignee")]
        public string Assignee { get; set; }

        [Display(Name = "Priority")]

        public Priority PrioritySelect { get; set; }

        [Display(Name = "Status")]
        public Status StatusSelect { get; set; }
       
    }
}