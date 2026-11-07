using System;
using System.Xml.Serialization;
using UnityEngine;

namespace Kilt
{
	[Serializable]
	public abstract class FoldOutStruct
	{
		[XmlIgnore]
		[SerializeField]
		private bool _foldOut;
	}
}
