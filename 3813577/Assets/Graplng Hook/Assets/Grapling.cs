using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapling : MonoBehaviour
{
	private LineRenderer Line;
	private Vector3 GrapplePoint;
	public LayerMask AbleToGraple;
	public Transform GunTip;
	public Transform camera;
	public float maxDistance;
	private SpringJoint joint;
	public GameObject PlayerObject;
	public Transform PlayerTrans;
	private Vector3 currentGrapplePosition;

	private void Awake()
	{
		Line = GetComponent<LineRenderer>();
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			StartGrapple();
		}
		else if (Input.GetMouseButtonUp(0))
		{
			StopGrapple();
		}
	}
	private void LateUpdate()
	{
		DrawRope();
	}

	void StartGrapple()
	{
		RaycastHit hit;
		if (Physics.Raycast(origin: camera.position, direction: camera.forward, out hit, maxDistance, AbleToGraple))
		{
			GrapplePoint = hit.point;
			joint = PlayerObject.gameObject.AddComponent<SpringJoint>();
			joint.autoConfigureConnectedAnchor = false;
			joint.connectedAnchor = GrapplePoint;

			float distanceFromPoint = Vector3.Distance(PlayerTrans.position, GrapplePoint);

			joint.maxDistance = distanceFromPoint * 0.8f;
			joint.minDistance = distanceFromPoint * 0.25f;

			joint.spring =20f;
			joint.damper = 0f;
			joint.massScale = 5f;

			Line.positionCount = 2;
			currentGrapplePosition = GunTip.position;
		}
	}

	void DrawRope()
	{
		if (!joint) return;

		currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, GrapplePoint, Time.deltaTime * 8f);
		Line.SetPosition(index: 0, GunTip.position);
		Line.SetPosition(index: 1, GrapplePoint);
		PlayerObject.GetComponent<PlayerMove>().enabled = false;
	}

	void StopGrapple()
	{
		Line.positionCount = 0;
		Destroy(joint);
		PlayerObject.GetComponent<PlayerMove>().enabled = true;
	}
}
