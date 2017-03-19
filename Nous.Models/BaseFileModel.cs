﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nous.Models
{
    public class BaseFileModel : BaseModel
    {
        [Required]
        public long Size { get; set; }

        public string Extension { get; set; }
    }
}