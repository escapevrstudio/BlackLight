using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchwarzlichtLampe : MonoBehaviour
{
    public Material reveal;
    public Light light;

    void Start()
    {

    }

    void Update()
    {
        reveal.SetVector("_LightPosition", light.transform.position);
        reveal.SetVector("_LightDirection", -light.transform.forward);
        reveal.SetFloat("_LightAngle", light.spotAngle);
    }
}
