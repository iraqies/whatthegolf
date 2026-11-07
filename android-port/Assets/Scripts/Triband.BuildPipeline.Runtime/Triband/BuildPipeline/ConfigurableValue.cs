using System;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	public class ConfigurableValue
	{
		[SerializeField]
		private string _stringValue;

		[SerializeField]
		private int _intValue;

		[SerializeField]
		private float _floatValue;

		[SerializeField]
		private bool _boolValue;

		[SerializeField]
		private UnityEngine.Object _objectValue;
	}
}
