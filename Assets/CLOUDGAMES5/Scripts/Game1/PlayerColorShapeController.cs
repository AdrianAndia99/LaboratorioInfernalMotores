using UnityEngine;
public class PlayerColorShapeController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ColorObject.OnChangeColor += UpdateColor;
        ShapeObject.OnChangeShape += UpdateShape;
    }

    private void UpdateColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }

    private void UpdateShape(Sprite newShape)
    {
        spriteRenderer.sprite = newShape;
    }

    private void OnDestroy()
    {
        ColorObject.OnChangeColor -= UpdateColor;
        ShapeObject.OnChangeShape -= UpdateShape;
    }
}