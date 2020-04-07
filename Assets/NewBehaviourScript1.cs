using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
