namespace Unity.Notifications.iOS
{
	internal struct LocationTriggerData
	{
		public double latitude;

		public double longitude;

		public float radius;

		public byte notifyOnEntry;

		public byte notifyOnExit;

		public byte repeats;
	}
}
