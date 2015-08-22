using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TeamSample4.Models
{
    public enum Status
    {
        [Display(Name = "open")]
        OPEN,
        [Display(Name = "closed")]
        CLOSED
    }
}