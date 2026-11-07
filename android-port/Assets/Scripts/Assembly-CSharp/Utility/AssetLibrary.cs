using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
	public class AssetLibrary<T> : ScriptableObject where T : Object
	{
		public List<T> Assets;

		public T GetAssetByName(string fileName)
		{
			return null;
		}
	}
}
