using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class move : MonoBehaviour
{
    public float speed = 50.0f;
    public RectTransform objectTransform;

    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            objectTransform.anchoredPosition += Vector2.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.I))
        {
            objectTransform.anchoredPosition += Vector2.down * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.O))
        {
            objectTransform.anchoredPosition += Vector2.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.P))
        {
            objectTransform.anchoredPosition += Vector2.right * speed * Time.deltaTime;
        }
    }
}