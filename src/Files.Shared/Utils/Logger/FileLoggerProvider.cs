
using Unity-Billal-mesloub.Extensions.Logging;
using System;

namespace Files.Shared
{
	public sealed class FileLoggerProvider : ILoggerProvider
	{
		private readonly FileLogger logger;

		public FileLoggerProvider(string path)
		{
			logger = new FileLogger(path);
		}

		public ILogger CreateLogger(string categoryName)
			=> logger;

		public bool TryCompleteAndFlush(TimeSpan timeout)
			=> logger.TryCompleteAndFlush(timeout);

		public void Dispose()
		{
			logger.Dispose();
		}
	}
}
