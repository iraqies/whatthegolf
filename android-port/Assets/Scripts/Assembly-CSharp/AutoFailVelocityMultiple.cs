public abstract class AutoFailVelocityMultiple : AutoFailBase
{
	public float velocityThreshold;

	public abstract float[] GetVelocities();

	private void FixedUpdate()
	{
	}
}
