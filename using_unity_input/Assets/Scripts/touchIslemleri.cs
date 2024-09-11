using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchIslemleri : MonoBehaviour
{
    public Text bilgi;
    public GameObject objem;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit_info;
            if (Physics.Raycast(ray,out hit_info))
            {
                Instantiate(objem, hit_info.point, Quaternion.identity);
            }

            //if (Input.GetTouch(0).phase == TouchPhase.Began)
            //{
            //    bilgi.text = Input.touchCount.ToString() + " Adet parmak var.";
            //}
            //if (Input.GetTouch(0).phase == TouchPhase.Stationary)
            //{
            //    bilgi.text = Input.touchCount.ToString() + " parmak hareket etmiyor.";
            //}
            //if (Input.GetTouch(0).phase == TouchPhase.Moved)
            //{
            //    bilgi.text = Input.touchCount.ToString() + " parmak hareket ediyor.";
            //}
            //if (Input.GetTouch(0).phase == TouchPhase.Ended)
            //{
            //    bilgi.text = " parmak kaldirildi.";
            //}
            //if (Input.GetTouch(0).phase == TouchPhase.Canceled)
            //{
            //    bilgi.text = "parmak izleme iptal edildi, takip edilemiyor.";
            //}

            //Touch touch = Input.GetTouch(0);
            //touch.
            //bilgi.text = Input.touchCount.ToString() + " Adet parmak var.";
            //if (touch.phase == TouchPhase.Began)
            //{
            //    bilgi.text = Input.touchCount.ToString() + " Adet parmak var.";
            //}
            //if (touch.phase == TouchPhase.Stationary)
            //{
            //    bilgi.text = Input.touchCount.ToString() + " parmak hareket etmiyor.";
            //}
            //if (touch.phase == TouchPhase.Moved)
            //{
            //    bilgi.text = Input.touchCount.ToString() + " parmak hareket ediyor.";
            //}
            //if (touch.phase == TouchPhase.Ended)
            //{
            //    bilgi.text = " parmak kaldirildi.";
            //}
            //if (touch.phase == TouchPhase.Canceled)
            //{
            //    bilgi.text = "parmak izleme iptal edildi, takip edilemiyor.";
            //}

            //for (global::System.Int32 i = 0; i < Input.touchCount; i++)
            //{
            //    if (Input.GetTouch(i).phase == TouchPhase.Moved)
            //    {
            //        bilgi.text = $"{i}. parmak hareket ediyor.";
            //    }
            //}
        }
    }
}
