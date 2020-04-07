using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BoxTrigger : MonoBehaviour
{
    public Flowchart flowchart;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
