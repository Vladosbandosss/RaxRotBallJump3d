using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;

    public float distanse = 7.6f;
    public float height = 2.5f;
    public float damping = 1.1f;
    public float rotationDamping = 0f;

    public bool smothRotation = true;
    public bool followBihind = true;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
  

    // Update is called once per frame
    void Update()
    {
        Vector3 wantedPos;

        if (followBihind)
        {
            wantedPos = target.TransformPoint(0f,height,-distanse);
        }
        else
        {
            wantedPos = target.TransformPoint(0f, height, distanse);
        }

        transform.position = Vector3.Lerp(transform.position, wantedPos, Time.deltaTime * damping);

        if (smothRotation)
        {
            Quaternion wantedRot = Quaternion.LookRotation(target.position-transform.position,target.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, wantedRot, Time.deltaTime * rotationDamping);
        }
        else
        {
            transform.LookAt(target, target.up);
        }

       
    }
}
