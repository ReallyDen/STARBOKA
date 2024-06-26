using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Image image;
    private bool draggingrn = false;
    private Vector2 initoffset;
    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        canvas = GetComponentInParent<Canvas>();
    }
    private void FixedUpdate()
    {
        if (draggingrn)
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 worldPoint2d = new Vector2(worldPoint.x, worldPoint.y);
            rb2D.MovePosition(worldPoint2d + initoffset);
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 wp2d = new Vector2(wp.x, wp.y);
        initoffset = rb2D.position - wp2d;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
        draggingrn = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;
        draggingrn = false;
    }
}