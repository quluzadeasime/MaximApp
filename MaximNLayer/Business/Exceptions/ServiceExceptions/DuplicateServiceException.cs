using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions.ServiceExceptions
{
	public class DuplicateServiceException : Exception
	{
		public DuplicateServiceException(string? message) : base(message)
		{
		}
	}
}
