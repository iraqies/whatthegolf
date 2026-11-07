using UnityEngine;

namespace DanceOff
{
	public abstract class Dancer : MonoBehaviour
	{
		public virtual void Dance(Vector2 dir)
		{
		}

		public virtual void Fail(Vector2 dir)
		{
		}
	}
}
