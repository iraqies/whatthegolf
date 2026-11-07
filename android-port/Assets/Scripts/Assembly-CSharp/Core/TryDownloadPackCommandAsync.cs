using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core
{
	public class TryDownloadPackCommandAsync
	{
		private ContentPack _contentPack;

		private bool IsOdrContent => false;

		public TryDownloadPackCommandAsync(ContentPack contentPack)
		{
		}

		public Task<bool> Execute()
		{
			return null;
		}

		private Task<bool> TryDownload()
		{
			return null;
		}

		private List<string> ResourceNames(string resourceName)
		{
			return null;
		}

		private static Task<bool> DownloadResources(List<string> resourceNames)
		{
			return null;
		}

		private Task LoadSceneLocations()
		{
			return null;
		}
	}
}
