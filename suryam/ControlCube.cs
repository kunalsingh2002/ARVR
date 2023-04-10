using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCube : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider RotateX;
    public Slider RotateY;
    public Slider RotateZ;
    public Slider ChangeScale;
    void Start()
    {
        RotateX.minValue = 0.0f;
        RotateX.maxValue = 360.0f;
        RotateY.minValue = 0.0f;
        RotateY.maxValue = 360.0f;
        RotateZ.minValue = 0.0f;
        RotateZ.maxValue = 360.0f;
        ChangeScale.minValue = 1.0f;
        ChangeScale.maxValue = 10.0f;

    }

    // Update is called once per frame
    void Update()
    {
        float rotXvalue = RotateX.value;
        float rotYvalue = RotateY.value;
        float rotZvalue = RotateZ.value;
        float scalevalue = ChangeScale.value;

        transform.eulerAngles = new Vector3(rotXvalue, rotYvalue, rotZvalue) ;
        transform.localScale = new Vector3(scalevalue, scalevalue, scalevalue);
    }
}
