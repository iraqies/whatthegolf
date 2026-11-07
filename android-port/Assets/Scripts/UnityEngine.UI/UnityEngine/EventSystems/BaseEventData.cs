namespace UnityEngine.EventSystems
{
	public class BaseEventData : AbstractEventData
	{
		private readonly EventSystem m_EventSystem;

		public GameObject selectedObject
		{
			set
			{
			}
		}

		public BaseEventData(EventSystem eventSystem)
		{
		}
	}
}
