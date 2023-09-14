using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10); 

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the offset in Start() instead of Update()
    }

    // Update is called once per frame
    void Update()
    {
        // Reposition the camera beside the plane
        transform.position = plane.transform.position + offset;
    }
}
