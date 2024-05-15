using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts;

public interface IServiceService
{
	void AddService(Service service);
	void DeleteService(int id);
	void UpdateCategory(int id, Service newService);
	Service GetService(Func<Service, bool>? func = null);
	List<Service> GetAllService(Func<Service, bool>? func = null);

}
