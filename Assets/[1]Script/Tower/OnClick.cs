using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnClick : MonoBehaviour
{
    [SerializeField] BoxCollider2D collider;
    public Action Clicked;
    void OnMouseDown()
    {
        Clicked?.Invoke();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPosition = new Vector2(wp.x, wp.y);

            if (collider == Physics2D.OverlapPoint(touchPosition)) OnMouseDown();
        }
    }
}
