using TMPro;
using UnityEngine;

public class StartPromptBlink : MonoBehaviour
{
    private TMP_Text text;
    private float speed = 2f;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        float alpha = Mathf.PingPong(Time.time * speed, 1f);
        Color c = text.color;
        c.a = alpha;
        text.color = c;
    }
}