using UnityEngine;

public class hide_on_web : MonoBehaviour
{
    public RectTransform recenter;

    void Awake()
    {
#if UNITY_WEBGL
        if (recenter != null)
        {
            float middle = (recenter.anchoredPosition.y + ((RectTransform)transform).anchoredPosition.y) / 2f;
            recenter.anchoredPosition = new Vector2(recenter.anchoredPosition.x, middle);
        }
        gameObject.SetActive(false);
#endif
    }
}