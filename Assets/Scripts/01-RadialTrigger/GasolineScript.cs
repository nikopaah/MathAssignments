using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;


public class GasolineScript : MonoBehaviour
{
    public Transform A;
    public Transform player;

    // When you make a build, this doesn't work on runtime
    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Vector3 playerPos = player.position;

        Vector3 gasLimit = A.position;
        Vector3 gasPos = transform.position;

        // Draw the A Vector
        Gizmos.color = Color.red;
        Gizmos.DrawLine(gasPos, gasLimit);

		// ############################################### //
		/*
         * My solution didn't work when you move the object to negative side :'(
         * 
         * 

        /* ## Trigger Explosion ## *//*

        // Get magnitude
        float playerLen = Mathf.Sqrt(playerPos.x * playerPos.x + playerPos.y * playerPos.y);
        float gasLimitLen = Mathf.Sqrt(gasLimit.x * gasLimit.x + gasLimit.y * gasLimit.y);

        
        // Don't getting sign problem
        playerLen = Mathf.Abs(playerLen);
        gasolineLen = Mathf.Abs(gasolineLen);

        //print("Player: " + playerLen + " | Gasoline: " + gasolineLen);

        if (playerLen < gasolineLen)
        { // EXPLOOOOOSION
            Handles.color = Color.red;
        }
        else
        {
            Handles.color = Color.white;
        }*/


		/* ================= Freya Solution ================= */

		/* ## Easy way ## */
		//float dist = Vector3.Distance(gasPos, playerPos);
		//float dist = Vector3.Dot(delta, delta);  // Squared length of delta
		Vector3 delta = gasPos - playerPos;

        // Use Sqrt is too expensive, so we can remove the squareroot and multiple by 2 after
        //float dist = Mathf.Sqrt(delta.x * delta.x + delta.y * delta.y + delta.z * delta.z);
        float sqrDist = delta.x * delta.x + delta.y * delta.y + delta.z * delta.z;


        // That's why we multiply by 2 the radius
        bool inside = sqrDist <= gasLimit.x*gasLimit.x;

        Handles.color = inside == true? Color.red : Color.white;
        
        /* ================================================== */


        // Draw the explosion area
        Handles.DrawWireDisc(transform.position, new Vector3(0, 1, 0), gasLimit.x);

    }
    #endif
}
