using System;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
	public class AddJobViewModel
	{
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        public string Name { get; set; }

        public int JobId { get; set; }

		public List<Employer> SelectListItem { get; set; }

        public AddJobViewModel()
		{
		}
	}
}

