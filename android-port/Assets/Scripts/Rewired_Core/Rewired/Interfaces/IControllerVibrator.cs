namespace Rewired.Interfaces
{
	public interface IControllerVibrator
	{
		int vibrationMotorCount { get; }

		void SetVibration(int motorIndex, float motorLevel, float duration);

		void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors);

		void StopVibration();
	}
}
