using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sling : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField] public Rigidbody2D snail;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        
    }

    private void Update()
    {
        SetLineRendererPosition();
    }

    private void SetLineRendererPosition()
    {
        Vector3[] positions = new Vector3[2];
        positions[0] = snail.position;
        positions[1] = new Vector3(this.transform.position.x, this.transform.position.y + 0.1f);
        lr.SetPositions(positions);
    }
    
}
