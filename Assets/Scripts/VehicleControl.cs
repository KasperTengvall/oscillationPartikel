using Unity.VisualScripting;
using UnityEngine;

public class VehicleControl : MonoBehaviour
{

    public float Speed;
    public float RotSpeed;

    public float Rot2Speed;

    GameObject Arm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Arm = GameObject.Find("Arm");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
        transform.Translate(0, 0, Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
        transform.Translate(0, 0, -Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
        transform.Rotate(0, -RotSpeed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
        transform.Rotate(0, RotSpeed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.W) == true)
        {
        Arm.transform.Rotate(0, 0, -Rot2Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) == true)
        {
        Arm.transform.Rotate(0, 0, Rot2Speed * Time.deltaTime);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Explosive")
        {
            Debug.Log("CRASH!");
        }
    }

}
