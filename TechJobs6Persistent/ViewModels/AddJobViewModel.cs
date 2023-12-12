using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
	public class AddJobViewModel
	{
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        public string Name { get; set; }

        public int EmployerId { get; set; }

		public List<SelectListItem>? listOfEmployers { get; set; }

        public AddJobViewModel()
		{

		}

		public AddJobViewModel(List<Employer> employers)
		{
			listOfEmployers = new List<SelectListItem>();
			foreach (var employer in employers)
			{
				listOfEmployers.Add(new SelectListItem
				{
					Text = employer.Name,
					Value = employer.Id.ToString()

				});

			}
		}
	}
}

