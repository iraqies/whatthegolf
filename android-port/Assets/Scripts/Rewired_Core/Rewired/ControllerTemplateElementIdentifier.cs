using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public class ControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier
	{
		[SerializeField]
		private int _id;

		[SerializeField]
		private string _name;

		[SerializeField]
		private string _positiveName;

		[SerializeField]
		private string _negativeName;

		[SerializeField]
		private ControllerTemplateElementType _elementType;

		internal readonly bool isMappableOnPlatform;

		public int id => 0;

		public string name => null;

		public string positiveName => null;

		public string negativeName => null;

		public ControllerTemplateElementType elementType => ControllerTemplateElementType.Axis;
	}
}
