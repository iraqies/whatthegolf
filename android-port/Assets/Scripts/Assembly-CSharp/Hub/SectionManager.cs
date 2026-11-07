using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hub
{
	public class SectionManager : MonoBehaviour
	{
		[SerializeField]
		private GameObject mainSectionPortrait;

		[SerializeField]
		private GameObject mainSectionLandscape;

		[SerializeField]
		private GameObject leftSectionPortrait;

		[SerializeField]
		private GameObject leftSectionLandscape;

		[SerializeField]
		private GameObject rightSectionPortrait;

		[SerializeField]
		private GameObject rightSectionLandscape;

		[SerializeField]
		private List<HideAreaOnConsoles> hideAreasScriptList;

		[SerializeField]
		private GridFiller gridFiller;

		[SerializeField]
		private List<HubPlatformSection> hubPlatformSections;

		public void Init()
		{
		}

		private IEnumerator FixColliders()
		{
			return null;
		}
	}
}
