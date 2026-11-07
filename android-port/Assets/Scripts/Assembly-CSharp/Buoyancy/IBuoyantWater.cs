namespace Buoyancy
{
	public interface IBuoyantWater
	{
		float Viscosity { get; }

		float WaterForceUp { get; }

		float SurfacePositionY { get; }
	}
}
