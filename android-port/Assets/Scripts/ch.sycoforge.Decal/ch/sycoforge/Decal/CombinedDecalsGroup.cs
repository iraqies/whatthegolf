using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class CombinedDecalsGroup : MonoBehaviour
	{
		[SerializeField]
		private DecalTextureAtlas atlas;

		[SerializeField]
		private List<EasyDecal> references;

		public DecalTextureAtlas Atlas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<EasyDecal> References
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
