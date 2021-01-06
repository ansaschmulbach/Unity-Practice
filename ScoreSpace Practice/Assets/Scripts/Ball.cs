using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Ball : MonoBehaviour
{
    
    private bool isPressed;
    private Rigidbody2D rb;
    private float releaseDelay;
    
    [SerializeField] SpringJoint2D springJoint2D;
    [SerializeField] private float maxDragDistance;
    [SerializeField] private Rigidbody2D slingRB;
    private LineRenderer lr;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        releaseDelay = 1 / (springJoint2D.frequency * 4f);
        lr = slingRB.GetComponent<LineRenderer>();
    }
    
    void Update()
    {
        if (isPressed)
        {
            DragBall();
        }
    }

    private void DragBall()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(mousePos, slingRB.position);
        if (distance > maxDragDistance)
        {
            Vector2 direction = (mousePos - slingRB.position).normalized;
            rb.position = slingRB.position + direction * maxDragDistance;
        }
        else
        {
            rb.position = mousePos;   
        }
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }
    
    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        lr.enabled = false;
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseDelay);
        springJoint2D.enabled = false;
    }
    
}
