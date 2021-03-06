using System.Collections.Generic;
using System.Threading.Tasks;
using Loader.Entries;
using Loader.Helper;
using Loader.Loader;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Loader.Services
{
	internal class ManufacturersService : LoaderService<Manufacturer>
	{
		private readonly ManufacturerLoader _manufacturerLoader;

		public ManufacturersService(ILogger<LoaderService<Manufacturer>> logger, IOptions<ServiceOptions> options,
		                            IJsonFileReaderWriter jsonFileReaderWriter, ManufacturerLoader manufacturerLoader)
			: base(logger, options, jsonFileReaderWriter)
		{
			_manufacturerLoader = manufacturerLoader;
		}

		protected override string FileName => "manufacturers.json";

		protected override Task<List<Manufacturer>> LoadItems()
		{
			return _manufacturerLoader.Load();
		}
	}
}
