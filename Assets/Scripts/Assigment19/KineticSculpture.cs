using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticSculpture : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float movementSpeed = 2f;
    public float colorChangeSpeed = 1f;

    private Material material;
    private Color startColor;
    private float timeElapsed;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        float moveDistance = Mathf.Sin(Time.time * movementSpeed) * 2f;
        transform.position = new Vector3(moveDistance, transform.position.y, transform.position.z);

        timeElapsed += Time.deltaTime;
        float colorValue = Mathf.Sin(timeElapsed * colorChangeSpeed) * 0.5f + 0.5f;
        material.color = Color.Lerp(startColor, Color.red, colorValue);
    }
}