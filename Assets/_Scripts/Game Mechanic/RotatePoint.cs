using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePoint : MonoBehaviour
{
    public float value = 100;

    private void Update()
    {
        transform.Rotate(0, 0, +value);
    }
}
