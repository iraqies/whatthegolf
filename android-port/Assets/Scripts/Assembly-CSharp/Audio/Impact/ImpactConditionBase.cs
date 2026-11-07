using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x2001407")]
	public abstract class ImpactConditionBase : ScriptableObject
	{
		[Token(Token = "0x4006B87")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEnabled;

		[Token(Token = "0x6005D41")]
		public abstract bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity);

		[Token(Token = "0x6005D42")]
		[Address(RVA = "0x14E7130", Offset = "0x14E7130", VA = "0x14E7130")]
		protected ImpactConditionBase()
		{
		}
	}
}
