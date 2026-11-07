using System;
using System.ComponentModel;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName]
	internal class BinaryAssetProvider<TAdapter> : BinaryDataProvider where TAdapter : BinaryStorageBuffer.ISerializationAdapter, new()
	{
		public override object Convert(Type type, byte[] data)
		{
			return null;
		}
	}
}
