using System.Runtime.CompilerServices;

namespace UnityEngine.EventSystems
{
	public class AxisEventData : BaseEventData
	{
		[CompilerGenerated]
		private Vector2 moveVector__BackingField;

		public Vector2 moveVector
		{
			[CompilerGenerated]
			set
			{
				moveVector__BackingField = value;
			}
		}

		public MoveDirection moveDir { get; set; }

		public AxisEventData(EventSystem eventSystem)
			: base(null)
		{
		}
	}
}
