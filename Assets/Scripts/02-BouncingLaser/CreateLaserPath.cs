using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLaserPath : MonoBehaviour
{
	public void OnDrawGizmos()
	{
		/* ================= Freya Solution ================= */

		Vector2 origin = transform.position;
        Vector2 dir = transform.right; // x axis
		Ray ray = new Ray(origin, dir);


		// If hit something
		if( Physics.Raycast(ray, out RaycastHit hit) )
		{
			// Draw hit point
			Gizmos.color = Color.cyan;
			Gizmos.DrawSphere(hit.point, 0.2f);

			// Draw path to hit point
			Gizmos.DrawLine(origin, hit.point);
		}

		// Draw direction
		Gizmos.color = Color.red;
		Gizmos.DrawLine(origin, origin + dir);
	}
}
