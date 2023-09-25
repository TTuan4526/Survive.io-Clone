using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectedGreen : MonoBehaviour
{
    public GameObject rotate;
    public GameObject points;
    internal bool updateFixed = false;

    void Start()
    {
        StartCoroutine(Spawning());
    }

   IEnumerator Spawning()
    {
        yield return new WaitForSeconds(0.4f);
        if (!updateFixed)
        {
            (Instantiate(rotate, transform.position, transform.rotation) as GameObject).transform.SetParent(points.transform);
        }
        StartCoroutine(Spawning());
    }
}
