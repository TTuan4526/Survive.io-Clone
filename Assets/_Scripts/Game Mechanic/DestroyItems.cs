using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItems : MonoBehaviour
{
    public float time = 0.3f;

    private void Start()
    {
        StartCoroutine(DestroyItem());
        transform.Rotate(0, 0, Random.Range(1, 180));
    }

    IEnumerator DestroyItem()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}
