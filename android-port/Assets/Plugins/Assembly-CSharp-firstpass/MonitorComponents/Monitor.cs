using System.Collections.Generic;
using UnityEngine;

namespace MonitorComponents
{
	public class Monitor
	{
		private class MonitorEventComparer : IComparer<MonitorEvent>
		{
			public int Compare(MonitorEvent a, MonitorEvent b)
			{
				return 0;
			}
		}

		private string name;

		private ValueAxisMode mode;

		public float latestTime;

		private float min;

		private float max;

		public List<MonitorInput> inputs;

		public List<MonitorEvent> events;

		private MonitorEventComparer monitorEventComparer;

		private GameObject gameObject;

		private MonitorEvent lookupEvent;

		public float Min
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Max
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string Name
		{
			set
			{
			}
		}

		public ValueAxisMode Mode
		{
			set
			{
			}
		}

		public GameObject GameObject
		{
			set
			{
			}
		}

		public Monitor(string name)
		{
		}

		public void Resize(float value, float time)
		{
		}

		public void Add(MonitorInput monitorInput)
		{
		}

		public void Add(MonitorEvent monitorEvent)
		{
		}

		public void MoveForward(float time)
		{
		}

		public void Remove(MonitorInput monitorInput)
		{
		}

		public void Close()
		{
		}
	}
}
