using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200002C")]
	public interface ILayerable
	{
		[Token(Token = "0x60001DA")]
		Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
	}
}
