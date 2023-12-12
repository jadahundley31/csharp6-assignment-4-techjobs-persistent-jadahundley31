using System;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
	public class AddEmployerViewModel
	{
		[Required(ErrorMessage = "Name is required.")]
		[StringLength(50)]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Only one location is required")]
        [StringLength(50)]
		public string? Location { get; set; }
    }
}

