using UnityEngine;

namespace Triband.BuildPipeline
{
	public class ConfigurableAddress : GuidScriptableObject
	{
		public enum EType
		{
			OBJECT = 0,
			STRING = 1,
			INT = 2,
			FLOAT = 3,
			BOOL = 4
		}

		internal const string UNKNOWN_TYPE = "[Any Type]";

		[SerializeField]
		private string _customAddress;

		[SerializeField]
		private EType _type;

		[SerializeField]
		private string _objectType;

		internal EType valueType => EType.OBJECT;

		internal string objectValueType => null;

		public string address => null;
	}
}
