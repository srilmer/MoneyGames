using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_trigger_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Move player to start location
    }

    // Update is called once per frame
    void Update()
    {
        // Movement per turn

        // is turn? -> Move ??px to left, right, front or back.

        // Check if next location is availible if not, maybe turn needed.
    }

    // upon collision with another GameObject
     private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Hit!");
    }
}
