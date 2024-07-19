using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackWithFlutter.Core.Models
{
	public class AppUser
	{
        public int Id { get; set; }
        public string FullName { get; set; }
        public string MobileNumber { get; set; }

        //auditable properties
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

		public DateTime? UpdatedDate { get; set; }
		public string UpdatedBy { get; set; }
	}
}
