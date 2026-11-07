using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	internal struct ColorTween : ITweenValue
	{
		public enum ColorTweenMode
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}

		public class ColorTweenCallback : UnityEvent<Color>
		{
		}

		private ColorTweenCallback m_Target;

		private Color m_StartColor;

		private Color m_TargetColor;

		private ColorTweenMode m_TweenMode;

		private float m_Duration;

		private bool m_IgnoreTimeScale;

		public Color startColor
		{
			set
			{
			}
		}

		public Color targetColor
		{
			set
			{
			}
		}

		public ColorTweenMode tweenMode
		{
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ignoreTimeScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void TweenValue(float floatPercentage)
		{
		}

		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
		}

		public bool ValidTarget()
		{
			return false;
		}
	}
}
