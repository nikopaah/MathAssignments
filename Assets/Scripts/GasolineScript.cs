using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GasolineScript : MonoBehaviour
{
    public Transform A;
    public Transform player;

    private void OnDrawGizmos()
    {
        Vector2 playerPos = player.position;

        Vector2 gasLimit = A.position;
        Vector2 gasPos = transform.position;

        // Draw the A Vector
        Gizmos.color = Color.red;
        Gizmos.DrawLine(gasPos, gasLimit);

        // ############################################### //

        /* ## Trigger Explosion ## */

        // Get magnitude
        float playerLen = Mathf.Sqrt(playerPos.x * playerPos.x + playerPos.y * playerPos.y);
        float gasolineLen = Mathf.Sqrt(gasLimit.x * gasLimit.x + gasLimit.y * gasLimit.y);

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
        }


        // Draw the explosion area
        Handles.DrawWireDisc(transform.position, new Vector3(0, 1, 0), gasLimit.x);

    }
}
