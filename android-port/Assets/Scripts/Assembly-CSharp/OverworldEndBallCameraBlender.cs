using UnityEngine;

public class OverworldEndBallCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings endCameraSettings;

	private Coroutine current;

	public Color baseBackground;

	public Color endBackground;

	public SpriteRenderer backgroundRenderer;

	private Coroutine currentColor;

	private bool isInEndMode;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
	}

	private void Start()
	{
		isInEndMode = false;
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
			if (OverworldBallManager.Instance.ball != null)
			{
				Transmogrif component = OverworldBallManager.Instance.ball.GetComponent<Transmogrif>();
				if (component != null)
				{
					CheckEndMode(component.shape);
				}
			}
		}
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES shape)
	{
		CheckEndMode(shape);
	}

	private void CheckEndMode(Transmogrif.BALLSHAPES shape)
	{
		if (shape == Transmogrif.BALLSHAPES.END && !isInEndMode)
		{
			isInEndMode = true;
			if (current != null)
			{
				StopCoroutine(current);
			}
			if (currentColor != null)
			{
				StopCoroutine(currentColor);
			}
			current = StartCoroutine(pTween.To(0.5f, delegate(float t)
			{
				float num = TweenFunctions.EaseIn(t);
				if (endCameraSettings != null)
				{
					endCameraSettings.SetWeight(this, num);
				}
			}));
			currentColor = StartCoroutine(pTween.To(0.2f, delegate(float t)
			{
				float t2 = TweenFunctions.EaseIn(t);
				if (backgroundRenderer != null)
				{
					backgroundRenderer.color = Color.Lerp(baseBackground, endBackground, t2);
				}
			}));
		}
		else if (shape != Transmogrif.BALLSHAPES.END && isInEndMode)
		{
			isInEndMode = false;
			if (current != null)
			{
				StopCoroutine(current);
			}
			if (currentColor != null)
			{
				StopCoroutine(currentColor);
			}
			current = StartCoroutine(pTween.To(0.5f, delegate(float t)
			{
				float num2 = TweenFunctions.EaseOut(1f - t);
				if (endCameraSettings != null)
				{
					endCameraSettings.SetWeight(this, num2);
				}
			}));
			currentColor = StartCoroutine(pTween.To(0.2f, delegate(float t)
			{
				float t3 = TweenFunctions.EaseIn(t);
				if (backgroundRenderer != null)
				{
					backgroundRenderer.color = Color.Lerp(endBackground, baseBackground, t3);
				}
			}));
		}
	}
}
