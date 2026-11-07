using UnityEngine;

namespace MonitorComponents
{
	public class MonitorInput
	{
		private Monitor monitor;

		private string description;

		private Color color;

		public int sampleIndex;

		public int numberOfSamples;

		public float[] samples;

		public float[] times;

		public int[] frames;

		public Color Color
		{
			set
			{
			}
		}

		public MonitorInput(Monitor monitor, string description)
		{
		}

		public MonitorInput(Monitor monitor, string description, Color color)
		{
		}

		public void Sample(float value)
		{
		}

		public void Close()
		{
		}
	}
}
