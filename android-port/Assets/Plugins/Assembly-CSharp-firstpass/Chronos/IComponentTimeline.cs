namespace Chronos
{
	public interface IComponentTimeline
	{
		void Initialize();

		void OnStartOrReEnable();

		void Update();

		void FixedUpdate();

		void OnDisable();

		void AdjustProperties();

		void Reset();
	}
}
