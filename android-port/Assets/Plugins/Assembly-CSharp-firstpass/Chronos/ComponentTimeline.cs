using UnityEngine;

namespace Chronos
{
	public abstract class ComponentTimeline<T> : IComponentTimeline where T : Component
	{
		protected Timeline timeline { get; private set; }

		public T component { get; internal set; }

		public ComponentTimeline(Timeline timeline, T component)
		{
			this.timeline = timeline;
			this.component = component;
		}

		public void Initialize()
		{
		}

		public virtual void OnStartOrReEnable()
		{
		}

		public virtual void Update()
		{
		}

		public virtual void FixedUpdate()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void CopyProperties(T source)
		{
		}

		public virtual void AdjustProperties(float timeScale)
		{
		}

		public void AdjustProperties()
		{
		}

		public virtual void Reset()
		{
		}
	}
}
