using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000078")]
	public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D
	{
		[Token(Token = "0x170000CC")]
		public abstract float SignalDuration
		{
			[Token(Token = "0x60002EF")]
			get;
		}

		[Token(Token = "0x60002F0")]
		public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x190BC30", Offset = "0x190BC30", VA = "0x190BC30")]
		protected SignalSourceAsset()
		{
		}
	}
}
