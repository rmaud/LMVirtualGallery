﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMVirtualGallery.Data
{
    public class Composition
    {
        [Key]
        public int CompositionId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        [Display(Name = "Name of Composition")]
        public string CompositionName { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Display(Name = "Composition Description")]
        public string CompositionDescription { get; set; }

        [Display(Name = "Composition Medium")]
        public string CompositionMedium { get; set; }

        [Display(Name = "Date of Composition Creation")]
        public string CompositionCreation { get; set; }
    }
}
