using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [Header("References")]
    public MeshRenderer Renderer;
    [Header("Position")]
    [SerializeField][Range(-20, 20)] private float xPos;
    [SerializeField][Range(-20, 20)] private float yPos;
    [SerializeField][Range(-20, 20)] private float zPos;
    [Header("Rotation")]
    [SerializeField] private float rotationSpeedX = 5f;
    [SerializeField] private float rotationSpeedY = 5f;
    [SerializeField] private float rotationSpeedZ = 5f;
    [Header("General settings")]
    [SerializeField][Range(0, 1)] private float alpha;
    [SerializeField] private float speedRanbow = 1f;
    [SerializeField] private float scale;


    private float time;

    void Update()
    {
        transform.position = new Vector3(xPos, yPos, zPos);
        transform.localScale = Vector3.one * scale;

        float xRot = Time.deltaTime * rotationSpeedX;
        float yRot = Time.deltaTime * rotationSpeedY;
        float zRot = Time.deltaTime * rotationSpeedZ;
        transform.Rotate(xRot, yRot, zRot);
        RanbowColor();
    }
    private void RanbowColor()
    {
        if (Renderer == null) return;

        Material material = Renderer.material;
        time += Time.deltaTime * speedRanbow;
        float r = Mathf.Sin(time) * 0.5f + 0.5f;
        float g = Mathf.Sin(time + 2f) * 0.5f + 0.5f;
        float b = Mathf.Sin(time + 4f) * 0.5f + 0.5f;

        Color color = new Color(r, g, b, alpha);
        material.color = color;
    }
}
