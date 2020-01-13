using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiImageFolder
	{
		public int Id
		{ get; set; }

		public string Name
		{ get; set; }

		public ApiImageFolderList ChildFolders
		{ get; set; }
	}
}
