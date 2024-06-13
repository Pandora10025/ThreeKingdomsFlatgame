using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public Transform target;
    public float followSpeed = .5f;

    private void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        this.transform.position = Vector3.Lerp(transform.position, newPos, followSpeed);

    }
}
