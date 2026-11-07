using System.Collections;
using UnityEngine;

public class MovimientosClaw : MonoBehaviour
{
	public bool MovingForward;

	public bool MovingBack;

	public bool MovingLeft;

	public bool MovingRight;

	public bool Grabbing;

	public float alturaMaxima;

	public float alturaMinima;

	public float correctorSeparacionTubos;

	public Animator animatorClaw;

	public float speed;

	public float speed_Claw;

	public Transform AlturaGancho;

	public Transform limitadorLeft;

	public Transform limitadorRight;

	public Transform limitadorFront;

	public Transform limitadorBack;

	public bool PuedeControlarse;

	private bool SoltarPremio;

	public bool[] LlegadoALaCesta;

	private bool dentroDeLaCesda;

	private bool bajarGanchoYSoltarPremio;

	private bool subirGanchoDeLaCesta;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void MoveForward(bool move)
	{
	}

	public void MoveBack(bool move)
	{
	}

	public void MoveLeft(bool move)
	{
	}

	public void MoveRight(bool move)
	{
	}

	public void Grab(bool grab)
	{
	}

	private IEnumerator CerrarClaw(float waitTime)
	{
		return null;
	}

	private IEnumerator SoltarPremioEnLaCesta(float waitTime)
	{
		return null;
	}

	private IEnumerator AbrirClawEnlaCesta(float waitTime)
	{
		return null;
	}

	public void AbrirClaw()
	{
	}

	public void CerrarClaw()
	{
	}
}
