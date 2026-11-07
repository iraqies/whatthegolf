using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200003C")]
	public interface IPropertyCollector
	{
		[Token(Token = "0x600020E")]
		void PushActiveGameObject(GameObject gameObject);

		[Token(Token = "0x600020F")]
		void PopActiveGameObject();

		[Token(Token = "0x6000210")]
		void AddFromClip(AnimationClip clip);

		[Token(Token = "0x6000211")]
		void AddFromName<T>(string name) where T : Component;

		[Token(Token = "0x6000212")]
		void AddObjectProperties(Object obj, AnimationClip clip);
	}
}
