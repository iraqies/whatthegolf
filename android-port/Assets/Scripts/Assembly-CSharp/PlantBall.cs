using System.Collections.Generic;
using Core;
using SpaceGolf;
using UnityEngine;

public class PlantBall : MonoBehaviour
{
	public GolfBallController FakeController;

	public GolfBallController PlanetController;

	public float PlanetFallVelocityMod;

	public bool UseGravityOnFall;

	public bool DisableKinematicOnShot;

	private Planet[] planets;

	private RotatingPlanet[] rotatingPlanets;

	private List<Rigidbody> planetRigidbodies;

	private void Start()
	{
	}

	private void FakeShoot(Vector3 boost)
	{
	}
}
