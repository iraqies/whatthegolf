using UnityEngine;

namespace Audio.Conditions
{
	public abstract class AudioCondition : MonoBehaviour
	{
		public abstract bool CheckCondition();
	}
}
