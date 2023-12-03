using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
	public class AddEmployerViewModel
	{
		[Required]
		[StringLength(50)]
		public string? Name { get; set; }

		[Required]
        [StringLength(50)]
		public string? Location { get; set; }
    }
}

