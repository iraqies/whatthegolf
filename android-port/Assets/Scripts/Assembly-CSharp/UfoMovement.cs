using UnityEngine;

public class UfoMovement : MonoBehaviour
{
	public float FlightHeight;

	public float MaxShipRotation;

	public float ShipRotationSpeed;

	public float HoverSpeed;

	private ConstantForce constForce;

	private float hoverMod;

	private Vector3 targetRot;

	private Rigidbody rigidbodyC;

	protected void Awake()
	{
	}

	private void Update()
	{
	}
}
