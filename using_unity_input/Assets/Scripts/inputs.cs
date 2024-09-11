using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputs : MonoBehaviour
{
    private float hiz = 15;
    private Rigidbody benim_fizigim;
    // Start is called before the first frame update
    void Start()
    {
        benim_fizigim = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float move_horizontal = Input.GetAxis("Horizontal");
        float move_vertical = Input.GetAxis("Vertical");
        float move_jump = Input.GetAxis("Jump");
        //transform.Translate(new Vector3(move_horizontal,0f,move_vertical) * hiz * Time.deltaTime);
        Vector3 fizik_hareketi = new Vector3(move_horizontal, move_jump, move_vertical);
        benim_fizigim.AddForce(fizik_hareketi * hiz);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.H))
        //{
        //    print("h basildi");
        //}
        //if (Input.GetButton("Fire1"))
        //{
        //    print("etkilesim suruyor");
        //}
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    print("etkilesim var");
        //}
        //if (Input.GetButtonUp("Fire1"))
        //{
        //    print("etkilesim bitti");
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    print("mouse sol tik ");
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    print("mouse sag tik ");
        //}
        //if (Input.GetMouseButton(2))
        //{
        //    print("mouse orta tik ");
        //}
        //if (Input.GetKey("joystick button 1"))
        //{
        //    print("Evet basildi ");
        //}
        //if (Input.GetKey("a"))
        //{
        //    print("'A' basildi");
        //}
        //if (Input.GetKeyDown("a"))
        //{
        //    print("A'ya basildi");
        //}
        //if (Input.GetKeyUp("a"))
        //{
        //    print("A'ya basildi");
        //}
        //if (Input.anyKey)
        //{
        //    print("giris var");
        //}
        //if (Input.anyKeyDown)
        //{
        //    print("giris var");
        //}

    }
}
