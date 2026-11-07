using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WwiseXMLRTPCData
{
	[Serializable]
	[DesignerCategory]
	[XmlType]
	public class WwiseDocumentGameParametersWorkUnitChildrenListGameParameter
	{
		private WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty[] propertyListField;

		private string nameField;

		private string idField;

		public WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty[] PropertyList => null;

		[XmlAttribute]
		public string Name => null;

		[XmlAttribute]
		public string ID => null;
	}
}
