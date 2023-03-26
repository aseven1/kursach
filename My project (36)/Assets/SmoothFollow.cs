using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SmoothFollow : MonoBehaviour
{
    public RectTransform target;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        // Новая позиция камеры
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));

        // Плавный переход к новой позиции
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}