﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Todo")]
    public class ToDo : EntityBase<int>
    {

        [Required]
        [Column("Tarefa")]
        public String Tarefa { get; set; }
    }
}
