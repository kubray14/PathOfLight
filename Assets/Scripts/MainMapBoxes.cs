using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMapBoxes : MonoBehaviour
{
    Vector3 refpos;
    public void BoxMovement() {

        while (transform.position.y <= 0) {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(0,0,0), ref refpos, 1.25f, 1.25f);
        }
    
    }
}
