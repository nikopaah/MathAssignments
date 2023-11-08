using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform Gasoline;

    private void OnDrawGizmos()
    {
        Vector2 gasPos = Gasoline.position;

        // Draw the A Vector
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(gasPos, transform.position);
    }
}
