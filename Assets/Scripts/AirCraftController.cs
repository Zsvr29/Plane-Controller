using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AirCraftController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float speed;
    public float maxSpeed, minSpeed;
    public float rotasyonSpeed1;
    public float rotasyonSpeed2;
    public float sayaç = 0;
  



    void Update()
    {


        transform.position += transform.forward * Time.deltaTime * speed;
        sayaç++;
        text.text = sayaç.ToString();
        Debug.Log(sayaç*Time.timeScale*0.0001f);


        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxSpeed)
            {
                speed++;
              

                if (Input.GetKey(KeyCode.S))
                {
                    if (speed > minSpeed)
                    {
                        speed-- ;


                    }
                    speed -= transform.forward.y * Time.deltaTime * 50;
                    if (speed<minSpeed/2)
                    {
                        speed = minSpeed;
                    }
                    else if (speed>maxSpeed*2)
                    {
                        speed = maxSpeed;
                    }


                }
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotasyonSpeed1);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * rotasyonSpeed1);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotasyonSpeed1);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotasyonSpeed1);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * rotasyonSpeed1);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down* Time.deltaTime * rotasyonSpeed1);

        }
    }
    
}
