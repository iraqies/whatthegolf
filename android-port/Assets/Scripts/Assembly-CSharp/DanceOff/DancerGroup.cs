using UnityEngine;

namespace DanceOff
{
	public class DancerGroup : Dancer
	{
		[SerializeField]
		private Dancer[] dancers;

		public override void Dance(Vector2 dir)
		{
		}

		public override void Fail(Vector2 dir)
		{
		}
	}
}
