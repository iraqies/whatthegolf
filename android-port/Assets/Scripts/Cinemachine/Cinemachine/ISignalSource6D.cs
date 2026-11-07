using UnityEngine;

namespace Cinemachine
{
	public interface ISignalSource6D
	{
		void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}
}
