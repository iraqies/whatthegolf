using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Hub
{
	public class SectionManager : MonoBehaviour
	{
		[SerializeField] private GameObject mainSectionPortrait;
		[SerializeField] private GameObject mainSectionLandscape;
		[SerializeField] private GameObject leftSectionPortrait;
		[SerializeField] private GameObject leftSectionLandscape;
		[SerializeField] private GameObject rightSectionPortrait;
		[SerializeField] private GameObject rightSectionLandscape;
		[SerializeField] private List<HideAreaOnConsoles> hideAreasScriptList;
		[SerializeField] private GridFiller gridFiller;
		[SerializeField] private List<HubPlatformSection> hubPlatformSections;

		public void Init()
		{
			if (hideAreasScriptList == null)
				hideAreasScriptList = new List<HideAreaOnConsoles>();
			for (int i = 0; i < transform.childCount; i++)
			{
				var child = transform.GetChild(i);
				if (child != null)
				{
					foreach (var h in child.GetComponents<HideAreaOnConsoles>())
					{
						if (h != null && !hideAreasScriptList.Contains(h))
							hideAreasScriptList.Add(h);
					}
				}
			}
			foreach (var h in hideAreasScriptList)
			{
				if (h != null)
					h.HideAndShow();
			}

			bool isLandscape = Screen.width >= Screen.height;
			if (mainSectionLandscape != null) mainSectionLandscape.SetActive(isLandscape);
			if (mainSectionPortrait != null) mainSectionPortrait.SetActive(!isLandscape);
			if (leftSectionLandscape != null) leftSectionLandscape.SetActive(isLandscape);
			if (leftSectionPortrait != null) leftSectionPortrait.SetActive(!isLandscape);
			if (rightSectionLandscape != null) rightSectionLandscape.SetActive(isLandscape);
			if (rightSectionPortrait != null) rightSectionPortrait.SetActive(!isLandscape);

			if (hubPlatformSections != null)
			{
				var defs = RuntimeStoreData.instance != null ? RuntimeStoreData.instance.contentPacksDefs : null;
				foreach (var sec in hubPlatformSections)
				{
					if (sec == null) continue;
					bool included = defs != null && defs.Any(c => c != null && c.pack != null && c.pack.contentPackID == sec.pack && c.accessible);
					sec.gameObject.SetActive(sec.disableIfPackIsIncluded ? !included : included);
				}
			}
		}

		private IEnumerator FixColliders()
		{
			yield break;
		}
	}
}
