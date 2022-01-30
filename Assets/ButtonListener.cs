using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListener : MonoBehaviour
{
    public GameObject cube;

    public void Counter()
    {
        cube.transform.Rotate(0, 0, 1);
    }
    public void Clock()
    {
        cube.transform.Rotate(0, 0, -1);
    }
}
