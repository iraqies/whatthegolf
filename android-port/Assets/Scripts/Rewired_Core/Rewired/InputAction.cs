using System;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputAction
	{
		[SerializeField]
		private int _id;

		[SerializeField]
		private string _name;

		[SerializeField]
		private InputActionType _type;

		[SerializeField]
		private string _descriptiveName;

		[SerializeField]
		private string _positiveDescriptiveName;

		[SerializeField]
		private string _negativeDescriptiveName;

		[SerializeField]
		private int _behaviorId;

		[SerializeField]
		private bool _userAssignable;

		[SerializeField]
		private int _categoryId;

		[NonSerialized]
		private string uJxdPoFMyIUVGOelCDviThTttvnz;

		[NonSerialized]
		private string gywqCDtuIMyhdXDfRAomvPXuOuKl;

		public int id => 0;

		public string name => null;

		public InputActionType type => InputActionType.Axis;

		public string descriptiveName => null;

		public string positiveDescriptiveName => null;

		public string negativeDescriptiveName => null;

		public int behaviorId => 0;

		public int categoryId => 0;
	}
}
