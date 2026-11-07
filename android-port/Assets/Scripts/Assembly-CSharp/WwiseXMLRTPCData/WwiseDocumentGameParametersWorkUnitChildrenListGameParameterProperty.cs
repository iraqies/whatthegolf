using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WwiseXMLRTPCData
{
	[Serializable]
	[DesignerCategory]
	[XmlType]
	public class WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty
	{
		private string nameField;

		private byte valueField;

		[XmlAttribute]
		public string Name => null;

		[XmlAttribute]
		public byte Value => 0;
	}
}
