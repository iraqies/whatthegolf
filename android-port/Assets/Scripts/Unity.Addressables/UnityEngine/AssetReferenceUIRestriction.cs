using System;

namespace UnityEngine
{
	public class AssetReferenceUIRestriction : Attribute
	{
		public virtual bool ValidateAsset(Object obj)
		{
			return false;
		}

		public virtual bool ValidateAsset(string path)
		{
			return false;
		}
	}
}
