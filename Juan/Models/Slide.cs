using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShopBtnText { get; set; }
        [NotMapped][Required]
        public IFormFile Photo { get; set; }
    }
}
