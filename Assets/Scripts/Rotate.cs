using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        // Rotate method takes 3 arguments (# coordinates), but we only need to rotate the saw in Z-direction rn.
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);        
    }
}
