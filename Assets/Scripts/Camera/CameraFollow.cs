using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    public float minDistance = 3f;
    public float maxDistance = 10f;
    public float minZ = -10f;
    public float maxZ = -5f;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        // Calculate initial distance between objects
        distance = Vector2.Distance(object1.position, object2.position);
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate current distance between objects
        float currentDistance = Vector2.Distance(object1.position, object2.position);

        // Calculate ratio of current distance to initial distance
        float ratio = currentDistance / distance;

        // Calculate new camera Z position based on distance ratio
        float newZ = Mathf.Lerp(minZ, maxZ, ratio);

        // Set camera position
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
    //void FixedUpdate()
    //{
        //Vector3 targetPosition = new Vector3(object1.position.x, object1.position.y, transform.position.z);
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    //}
 }
