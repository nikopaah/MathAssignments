using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class TriggerExplosion : MonoBehaviour
{
    public Transform player;
    public Transform gasoline;

    private Vector2 playerPos, gasolinePos;
    private float playerLen, gasolineLen;


    private void OnDrawGizmos()
    {
        playerPos = player.position;
        gasolinePos = gasoline.position;

        // Get magnitude
        playerLen = Mathf.Sqrt(playerPos.x * playerPos.x + playerPos.y * playerPos.y);
        gasolineLen = Mathf.Sqrt(gasolinePos.x * gasolinePos.x + gasolinePos.y * gasolinePos.y);

        if (playerLen < gasolineLen)
        { // EXPLOOOOOSION
            Gizmos.DrawCube(gasolinePos, gasolinePos);
        }
    }

}
