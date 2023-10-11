using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform gasoline;

    private void OnDrawGizmos()
    {
        Vector2 gasPos = gasoline.position;

        // Draw the A Vector
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(gasPos, transform.position);
    }
}
