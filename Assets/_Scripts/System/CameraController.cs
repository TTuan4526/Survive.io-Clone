using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject spinner;
    public float speedMove;
    public Vector3 offset;
    private Vector3 rb;
    internal bool manage = true;

    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref rb, speedMove);
    }

    private void Update()
    {
        if (spinner.activeSelf == true && manage == true)
        {
            this.gameObject.GetComponent<Camera>().fieldOfView += 0.5f;
            if(this.gameObject.GetComponent<Camera>().fieldOfView == 85)
            {
                manage = false;
            }
        }
    }
}
