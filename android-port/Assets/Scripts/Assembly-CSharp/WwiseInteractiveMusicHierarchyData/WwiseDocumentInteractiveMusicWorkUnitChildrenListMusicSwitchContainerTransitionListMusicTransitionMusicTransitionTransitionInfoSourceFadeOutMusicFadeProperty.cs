using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[DesignerCategory]
	[XmlType]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransitionTransitionInfoSourceFadeOutMusicFadeProperty
	{
		private string nameField;

		private string typeField;

		private decimal valueField;

		[XmlAttribute]
		public string Name => null;

		[XmlAttribute]
		public decimal Value => 0m;
	}
}
