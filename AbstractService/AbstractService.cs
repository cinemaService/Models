using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractService
{
	public class AbstractService
	{
		protected string serviceName;

		protected AbstractService(string serviceName)
		{
			this.serviceName = serviceName;
			// TO DO : LOGGER
		}
	}
}
