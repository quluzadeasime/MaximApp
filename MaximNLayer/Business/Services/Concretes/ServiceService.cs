using Business.Exceptions.ServiceExceptions;
using Business.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
	public class ServiceService : IServiceService
	{
		private readonly IServiceRespository _serviceRespository;

		public ServiceService(IServiceRespository serviceRespository)
		{
			_serviceRespository = serviceRespository;
		}

		public void AddService(Service service)
		{
			if (service == null) throw new NullReferenceException("Service null ola bilmez!");
			if (!_serviceRespository.GetAll().Any(x => x.Title == service.Title))
			{
				_serviceRespository.Add(service);
				_serviceRespository.Commit();
			}
			else
			{
				throw new DuplicateServiceException("Eyni ad tekrarlana bilmez!");
			}
			
		}

		public void DeleteService(int id)
		{
			var existService = _serviceRespository.Get(x => x.Id == id);
			if (existService == null) throw new NullReferenceException("Service yoxdur");
			_serviceRespository.Delete(existService);
			_serviceRespository.Commit();
		}

		public List<Service> GetAllService(Func<Service, bool>? func = null)
		{
			return _serviceRespository.GetAll(func);
		}

		public Service GetService(Func<Service, bool>? func = null)
		{
			return _serviceRespository.Get(func);
		}

		public void UpdateCategory(int id, Service newService)
		{
			var existService = _serviceRespository.Get(x => x.Id == id);
			if (existService == null) throw new NullReferenceException("Service yoxdur");
			if (_serviceRespository.GetAll().Any(x => x.Title == newService.Title))
			{
				existService.Title = newService.Title;
				_serviceRespository.Commit();
			}
			else throw new DuplicateServiceException("Title eyni ola bilmez!");
		}
	}
}
