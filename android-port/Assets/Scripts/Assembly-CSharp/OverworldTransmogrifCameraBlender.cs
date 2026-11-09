using System.Collections;
using CameraStack;
using UnityEngine;

public class OverworldTransmogrifCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings inTrans;

	public OverworldCameraSettings inTransZoomed;

	private Coroutine current;

	[SerializeField]
	private OverworldCamera overworldCamera;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		overworldCamera = FindObjectOfType<OverworldCamera>();
	}

	private void Start()
	{
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnTransmoGriffed -= Instance_OnTransmoGriffed1;
			OverworldBallManager.Instance.OnTransmoGriffed += Instance_OnTransmoGriffed1;
		}
	}

	private void Instance_OnTransmoGriffed1(Transmogrif grif)
	{
		if (current != null) StopCoroutine(current);
		current = StartCoroutine(DoCameraBlend());
	}

	private IEnumerator DoCameraBlend()
	{
		yield return StartCoroutine(pTween.To(0.25f, 0f, 1f, t =>
		{
			if (inTrans != null)
				inTrans.SetValue(t);
		}));
		yield return new WaitForSeconds(0.4f);
		yield return StartCoroutine(pTween.To(0.25f, 1f, 0f, t =>
		{
			if (inTrans != null)
				inTrans.SetValue(t);
		}));
	}
}
