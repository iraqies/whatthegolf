namespace UnityEngine.EventSystems
{
	public class BaseInput : UIBehaviour
	{
		public virtual string compositionString => null;

		public virtual IMECompositionMode imeCompositionMode
		{
			get
			{
				return IMECompositionMode.Auto;
			}
			set
			{
			}
		}

		public virtual Vector2 compositionCursorPos
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public virtual bool mousePresent => false;

		public virtual Vector2 mousePosition => default;

		public virtual Vector2 mouseScrollDelta => default;

		public virtual bool touchSupported => false;

		public virtual int touchCount => 0;

		public virtual bool GetMouseButtonDown(int button)
		{
			return false;
		}

		public virtual bool GetMouseButtonUp(int button)
		{
			return false;
		}

		public virtual bool GetMouseButton(int button)
		{
			return false;
		}

		public virtual Touch GetTouch(int index)
		{
			return default;
		}

		public virtual float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		public virtual bool GetButtonDown(string buttonName)
		{
			return false;
		}
	}
}
