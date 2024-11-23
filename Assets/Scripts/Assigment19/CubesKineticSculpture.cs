using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  public float rotationSpeed = 50f;
    public float orbitSpeed = 20f;
    public float colorChangeSpeed = 1f;
    public float sizeChangeSpeed = 0.1f;

    private Material material;
    private Color startColor;
    private Vector3 startScale;
    private float timeElapsed;
    private int rotationCount;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
        startScale = transform.localScale;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

   
        transform.RotateAround(Vector3.zero, Vector3.up, orbitSpeed * Time.deltaTime);

        rotationCount++;

   
        if (rotationCount % 5 == 0)
        {
            timeElapsed += Time.deltaTime;
            float colorValue = Mathf.Sin(timeElapsed * colorChangeSpeed) * 0.5f + 0.5f;
            material.color = Color.Lerp(startColor, Color.blue, colorValue);

            float sizeValue = Mathf.Sin(timeElapsed * sizeChangeSpeed) * 0.25f + 1f;
            transform.localScale = startScale * sizeValue;
        }
    }
}
