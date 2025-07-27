using UnityEngine;

public class Cube : MonoBehaviour
{
    [Header("References")]
    public MeshRenderer Renderer;
    [Header("Position")]
    [SerializeField][Range(-20, 20)] private float xPos;
    [SerializeField][Range(-20, 20)] private float yPos;
    [SerializeField][Range(-20, 20)] private float zPos;
    [Header("Speed")]
    public float speedRotation = 5f;
    public float speedRanbow = 1f;
    [Header("General settings")]
    [Range(0, 1)] public float alpha;

    private float time;

    void Update()
    {
        transform.position = new Vector3(xPos, yPos, zPos);
    }
    public void RainbowColor()
    {
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
    public void CubeRotation()
    {
        float xRot = Time.deltaTime * speedRotation;
        float yRot = Time.deltaTime * speedRotation;
        float zRot = Time.deltaTime * speedRotation;
        transform.Rotate(xRot, yRot, zRot);
    }
    public void SetScale(float scale)
    {
        // this.scale = scale;
        transform.localScale = Vector3.one * scale;
    }
    public void SetSimpleColor(Color setColor)
    {
        Material material = Renderer.material;
        Color color = setColor;
        material.color = color;
    }
    public void SetTransparent(float transparent)
    {

    }
}
