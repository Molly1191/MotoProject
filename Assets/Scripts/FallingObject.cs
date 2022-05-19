using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    protected float fallSpeed = 1f;
    protected float yAxisValue = -1f;
    protected bool isFalling;

    // Start is called before the first frame update
    void Start()
    {

    }

    protected void Fall()
    {
        transform.Translate(new Vector3(0, yAxisValue, 0) * fallSpeed * Time.deltaTime);
    }

    protected virtual void HitGround()
    {
        isFalling = false;
    }
}
