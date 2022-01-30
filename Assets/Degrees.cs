using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Degrees : MonoBehaviour
{
    public GameObject cube;
    Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = cube.transform.eulerAngles.z + " Degrees";
    }
}
