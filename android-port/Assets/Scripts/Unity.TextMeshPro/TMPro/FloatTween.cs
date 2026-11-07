using UnityEngine.Events;

namespace TMPro
{
	internal struct FloatTween : ITweenValue
	{
		public class FloatTweenCallback : UnityEvent<float>
		{
		}

		private FloatTweenCallback m_Target;

		private float m_StartValue;

		private float m_TargetValue;

		private float m_Duration;

		private bool m_IgnoreTimeScale;

		public float startValue
		{
			set
			{
			}
		}

		public float targetValue
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

		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		public bool ValidTarget()
		{
			return false;
		}
	}
}
