using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Loader.Helper
{
	internal interface IJsonFileReaderWriter
	{
		Task WriteFile(string jsonFilename, Func<object> getObject, CancellationToken cancellationToken = default);

		Task<T> ReadFile<T>(string jsonFileName, CancellationToken cancellationToken);
	}

	internal class JsonFileReaderWriter : IJsonFileReaderWriter
	{
		private readonly ILogger<JsonFileReaderWriter> _logger;

		private readonly ServiceOptions _options;

		public JsonFileReaderWriter(ILogger<JsonFileReaderWriter> logger, IOptions<ServiceOptions> options)
		{
			JsonConvert.DefaultSettings = () => new JsonSerializerSettings
			                                    {
				                                    Formatting = Formatting.Indented,
				                                    NullValueHandling = NullValueHandling.Ignore,
				                                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
			                                    };


			_logger = logger;
			_options = options.Value;
		}

		public async Task WriteFile(string jsonFilename, Func<object> getObject,
		                            CancellationToken cancellationToken = default)
		{
			if (_options.WriteRawJsonFiles)
			{
				var obj = getObject();
				_logger.LogDebug($"Write object with type {obj.GetType()} to {jsonFilename}");

				var json = JsonConvert.SerializeObject(obj);
				await File.WriteAllTextAsync(jsonFilename, json, cancellationToken);
			}
		}

		public async Task<T> ReadFile<T>(string jsonFileName, CancellationToken cancellationToken)
		{
			var json = await File.ReadAllTextAsync(jsonFileName, cancellationToken);
			return JsonConvert.DeserializeObject<T>(json);
		}
	}
}
