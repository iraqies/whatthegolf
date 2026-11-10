using UnityEngine;

namespace GolfHero
{
	public class NoteTarget : MonoBehaviour
	{
		[SerializeField]
		private Renderer renderer;

		public Material Material
		{
			get
			{
				return renderer != null ? renderer.sharedMaterial : null;
			}
			set
			{
				if (renderer != null)
				{
					renderer.sharedMaterial = value;
				}
			}
		}
	}
}
