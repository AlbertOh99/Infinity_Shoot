using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCam : MonoBehaviour
{

    public Transform head;
    public float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, head.localPosition, Time.deltaTime * followSpeed);
    }
}
