using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class MakeFlagsAppear : MonoBehaviour
{
	[SerializeField]
	private Transform AppearingThingsContainer;

	private List<Animator> appearingAnimators;

	public ClipSettingsCollection FlagAppearSound;

	private void Start()
	{
	}

	public void Appear()
	{
	}

	private IEnumerator AppearCR()
	{
		return null;
	}
}
