using System.Collections;
using UnityEngine;

public class MainMenuInputIconGroup : MonoBehaviour
{
	[SerializeField]
	private MainMenuInputIcon[] inputIcons;

	[SerializeField]
	private AnimationCurve visibility;

	[SerializeField]
	private bool fadeIcons;

	[SerializeField]
	private Vector3 fadeOutDirection;

	[SerializeField]
	private Vector3 fadeOutScale;

	private SVGImage[] images;

	private Transform selfTransform;

	private Vector3 localPosition;

	private Transform[] imageTransforms;

	private Vector3[] imageScales;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator FadeInOutCR()
	{
		return null;
	}

	private void SetImageAlphas(SVGImage[] images, float alpha)
	{
	}
}
