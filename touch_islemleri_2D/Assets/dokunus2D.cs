using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokunus2D : MonoBehaviour
{
    public GameObject objem;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch;

            for (global::System.Int32 i = 0; i < Input.touchCount; i++)
            {
                touch = Input.GetTouch(i);
                Vector2 dokunma_pozisyonu = Camera.main.ScreenToWorldPoint(touch.position);
                Instantiate(objem, dokunma_pozisyonu, Quaternion.identity);

            }
        }
    }
}
