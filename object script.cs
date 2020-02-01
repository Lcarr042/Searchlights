using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehavior
{

    public GameObject cube;

    public void Enable() {
        cube.SetActive(true);
    }
    public void Disable() {
        cube.SetActive(false);
    }
}