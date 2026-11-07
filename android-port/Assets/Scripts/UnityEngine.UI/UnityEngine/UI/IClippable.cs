namespace UnityEngine.UI
{
	public interface IClippable
	{
		GameObject gameObject { get; }

		void RecalculateClipping();

		void SetClipRect(Rect value, bool validRect);

		void SetClipSoftness(Vector2 clipSoftness);
	}
}
