using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KineticSculptures2 : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float orbitSpeed = 20f;
    public float colorChangeSpeed = 1f;

    private Material material;
    private Color startColor;
    private float timeElapsed;
    private Transform otherCylinder;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
        otherCylinder = GameObject.Find("OtherCylinder").transform; 
    }

    void Update()
    {

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        transform.RotateAround(otherCylinder.position, Vector3.up, orbitSpeed * Time.deltaTime);

        timeElapsed += Time.deltaTime;
        float colorValue = Mathf.Sin(timeElapsed * colorChangeSpeed) * 0.5f + 0.5f;
        material.color = Color.Lerp(startColor, Color.red, colorValue);
    }
}