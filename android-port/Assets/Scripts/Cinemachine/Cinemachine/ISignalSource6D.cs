using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000077")]
	public interface ISignalSource6D
	{
		[Token(Token = "0x60002EE")]
		void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}
}
