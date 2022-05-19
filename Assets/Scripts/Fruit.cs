using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : FallingObjectController
{
    // Start is called before the first frame update
    void Start()
    {
        isFalling = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFalling)
        {
            Fall();
        }
    }

    protected override void HitGround()
    {
        base.HitGround();
    }
}
