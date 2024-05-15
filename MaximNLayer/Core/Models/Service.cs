using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
	public class Service:BaseEntity
	{
		[Required]
		[StringLength(20, ErrorMessage = "Max uzunluq 20 ola biler!")]
		public string Title { get; set; } = null!;
		[Required]
		[StringLength(50, ErrorMessage = "Max uzunluq 50 ola biler!")]
		public string Description { get; set; } = null!;
		[MinLength(5)]
		[MaxLength(50)]
		public string? ImgUrl { get; set; } = null!;
		[NotMapped]
		public IFormFile PhotoFile { get; set; } = null!;
	}
}
