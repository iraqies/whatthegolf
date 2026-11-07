using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200003D")]
	public interface IPropertyPreview
	{
		[Token(Token = "0x6000213")]
		void GatherProperties(PlayableDirector director, IPropertyCollector driver);
	}
}
