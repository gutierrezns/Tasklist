﻿using System.ComponentModel.DataAnnotations;

namespace BE_Netcore.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

       
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
