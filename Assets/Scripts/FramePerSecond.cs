using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FramePerSecond : MonoBehaviour
{
    private TextMeshProUGUI fpsText;
    private float deltaTime = 0;

    void Start()
    {
        fpsText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = "FPS: " + Mathf.Ceil(fps).ToString();
    }
}
