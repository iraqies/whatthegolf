using UnityEngine;

namespace Rewired.UI
{
	public interface ITouchInputSource
	{
		bool touchSupported { get; }

		int touchCount { get; }

		Touch GetTouch(int index);
	}
}
