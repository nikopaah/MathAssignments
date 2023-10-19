using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLaserPath : MonoBehaviour
{
    public Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();
    }

    private void CheckForColliders()
    {
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log(hit.collider.gameObject.name + "was hit");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
