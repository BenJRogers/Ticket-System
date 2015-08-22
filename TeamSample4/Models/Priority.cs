using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TeamSample4.Models
{
    public enum Priority
    {
        [Display(Name="Very Low")]
        VeryLow,
        [Display(Name="Low")]
        Low,
        [Display(Name="Midium")]
        Midium,
        [Display(Name="High")]
        High,
        [Display(Name="Very High")]
        VeryHigh
    }
}