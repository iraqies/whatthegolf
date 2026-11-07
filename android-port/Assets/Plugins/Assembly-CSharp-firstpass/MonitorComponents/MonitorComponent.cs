using System;
using System.Collections.Generic;
using UnityEngine;

namespace MonitorComponents
{
	[ExecuteInEditMode]
	public class MonitorComponent : MonoBehaviour
	{
		[Serializable]
		public class MonitorInputField
		{
			public string[] field;

			public Color color;

			public string fieldTypeName;

			public MonitorInput monitorInput;
		}

		public Component component;

		public List<MonitorInputField> monitorInputFields;

		private List<MonitorInputField> oldMonitorInputFields;

		public Monitor monitor;

		public ValueAxisMode mode;

		public float min;

		public float max;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateMonitors()
		{
		}

		public void Update()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		private void RemoveMonitor()
		{
		}
	}
}
