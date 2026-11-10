using UnityEngine;

public class PropRain : MonoBehaviour
{
	public GameObject Prop;

	public bool Raining;

	public float MaximumRandomPositionOffset;

	public float PropLifetime;

	public float rainCooldownMax;

	private float rainCooldownTime;

	private float rainCooldownTimer;

	private void Update()
	{
		if (Raining)
		{
			rainCooldownTimer += Time.deltaTime;
			if (rainCooldownTimer > rainCooldownTime)
			{
				NewProp();
				NewProp();
				rainCooldownTimer = 0f;
				rainCooldownTime = Random.Range(0f, rainCooldownMax);
			}
		}
	}

	private void NewProp()
	{
		GameObject gameObject = Object.Instantiate(Prop, base.transform.position, Quaternion.identity);
		Vector3 zero = Vector3.zero;
		zero.x = Random.Range(base.transform.position.x - MaximumRandomPositionOffset, base.transform.position.x + MaximumRandomPositionOffset);
		zero.z = Random.Range(base.transform.position.z - MaximumRandomPositionOffset, base.transform.position.z + MaximumRandomPositionOffset);
		zero.y = base.transform.position.y;
		gameObject.transform.position = zero;
		gameObject.transform.rotation = Random.rotation;
		Object.Destroy(gameObject, PropLifetime);
	}
}
