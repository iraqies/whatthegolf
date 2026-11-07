namespace UnityEngine.Timeline
{
	public interface IPropertyCollector
	{
		void PushActiveGameObject(GameObject gameObject);

		void PopActiveGameObject();

		void AddFromClip(AnimationClip clip);

		void AddFromName<T>(string name) where T : Component;

		void AddObjectProperties(Object obj, AnimationClip clip);
	}
}
