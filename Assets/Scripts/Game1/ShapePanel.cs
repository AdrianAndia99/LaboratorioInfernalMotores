using UnityEngine;
using UnityEngine.UI;
public class ShapePanel : MonoBehaviour
{
    [SerializeField] private Image shapeImage;

    private void OnEnable()
    {
        ShapeObject.OnChangeShape += UpdateShape;
    }

    private void UpdateShape(Sprite newShape)
    {
        shapeImage.sprite = newShape;
    }

    private void OnDisable()
    {
        ShapeObject.OnChangeShape -= UpdateShape;
    }
}