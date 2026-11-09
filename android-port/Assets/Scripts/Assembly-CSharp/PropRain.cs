using UnityEngine;

public class PropRain : MonoBehaviour
{
	public GameObject Prop;
	public bool Raining;
	public float MaximumRandomPositionOffset = 5f;
	public float PropLifetime = 5f;
	public float rainCooldownMax = 0.2f;
	private float rainCooldownTime;
	private float rainCooldownTimer;

	private void Update()
	{
		if (!Raining || Prop == null) return;
		rainCooldownTimer += Time.deltaTime;
		if (rainCooldownTimer >= rainCooldownTime)
		{
			rainCooldownTimer = 0f;
			rainCooldownTime = Random.Range(0.02f, Mathf.Max(0.05f, rainCooldownMax));
			NewProp();
		}
	}

	private void NewProp()
	{
		if (Prop == null) return;
		Vector3 offset = Random.insideUnitSphere * MaximumRandomPositionOffset;
		offset.y = 0f;
		var go = Instantiate(Prop, transform.position + offset, Random.rotation);
		if (PropLifetime > 0f)
			Destroy(go, PropLifetime);
	}
}
