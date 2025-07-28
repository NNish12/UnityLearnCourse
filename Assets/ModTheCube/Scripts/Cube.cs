using UnityEngine;

public class Cube : MonoBehaviour
{
    [Header("References")]
    public MeshRenderer Renderer;
    [SerializeField] private float speedRotation = 5f;
    [SerializeField] private float speedRainbow = 1f;
    [Header("General settings")]
    [Range(0, 1)] public float alpha;

    private float time;
    public float SpeedRotation
    {
        get => speedRotation;
        set
        {
            speedRotation = value;
        }
    }
    public float SpeedRainbow
    {
        get => speedRainbow;
        set
        {
            speedRainbow = value;
        }
    }
    public void RainbowColor()
    {
        {
            if (Renderer == null) return;

            Material material = Renderer.material;
            time += Time.deltaTime * speedRainbow;
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
        transform.localScale = Vector3.one * scale;
    }
    public void SetSimpleColor(Color setColor)
    {
        Material material = Renderer.material;
        Color newColor = new Color(setColor.r, setColor.g, setColor.b, alpha);
        material.color = newColor;
    }
    public void SetTransparent(float transparent)
    {
        alpha = transparent;
        Color oldColor = Renderer.material.color;
        Color color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
        Renderer.material.color = color;
    }
}

