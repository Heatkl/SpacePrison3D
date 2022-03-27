using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(CharacterController))]
//[AddComponentMenu("Control Script/FPS Input")]

public class FPSInput : MonoBehaviour
{
    [SerializeField] private GameObject winText;
    private float speed = 10f;
    private Rigidbody m_Rigidbody;
    private float m_Thrust = 40f;
    private bool isJumping = false;
    private Animator anim;
    //private Camera cam;
    private FPSInput scr1;
    //private MouseLook scr2;
    //private MouseLook scr2;



    // Start is called before the first frame update
    void Start()
    {
        //cam = transform.Find("MainCamera");
        anim = gameObject.GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey == false && isJumping == false)
        {
            aniMethod("Idle");
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                aniMethod("Forward");
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                aniMethod("Back");
                transform.Translate(0, 0, speed * (-1) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                aniMethod("Right");
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                aniMethod("Left");
                transform.Translate(speed * (-1) * Time.deltaTime, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
            {
                //Apply a force to this Rigidbody in direction of this GameObjects up axis
                Invoke("changeCondition", 0.1f);
                aniMethod("Jump");
                m_Rigidbody.AddForce(transform.up * m_Thrust, ForceMode.Impulse);
            }
            //transform.Translate(Input.GetAxis("Horizontal") / speed, 0, Input.GetAxis("Vertical") / speed);
        }
    }

    private void changeCondition()
    {
        isJumping = !isJumping;


    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Finish")
        {
            switch (col.gameObject.name) {
                case "TeleportCube":
                    transform.position = new Vector3(0, 85.3f, 0);
                    break;
                case "TeleportCube1":
                    transform.position = new Vector3(0, 76.29f, -10f);
                    break;
                case "TeleportCube2":
                    transform.position = new Vector3(0, 85.3f, 0);
                    break;
                case "TeleportCube3":
                    winText.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    
                    break;
                case "TeleportCube4":
                    transform.position = new Vector3(0, 85.3f, 0);
                    break;
                case "TeleportCube5":
                    transform.position = new Vector3(0, 157.1f, -20f);
                    break;
                case "TeleportCube6":
                    transform.position = new Vector3(0, 85.3f, 0);
                    break;
                case "TeleportCube7":
                    transform.position = new Vector3(0, 209.9f, -29.77f);
                    break;
                case "TeleportCube8":
                    transform.position = new Vector3(0, 118f, 20f);
                    break;
                case "TeleportCube9":
                    transform.position = new Vector3(0, 85.3f, 0);
                    break;
                case "TeleportCube10":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube11":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube12":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube13":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube14":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube15":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube16":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube17":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube18":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube19":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube20":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube21":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube22":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube23":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube24":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube25":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube26":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube27":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;
                case "TeleportCube28":
                    transform.position = new Vector3(Random.Range(-100f, 100f), Random.Range(10f, 100f), Random.Range(-100f, 100f));
                    break;

            }
        }
    }
    void OnCollisionStay()
    {
        //if(isJumping == true) Invoke("changeCondition", 0.1f);
        isJumping = false;
    }

    private void aniMethod(string _state)
    {
        if( isJumping == false) {
            switch (_state){
                case "Idle":
                    State = States.Idle;
                    break;
                case "Forward":
                    State = States.Forward;
                    break;
                case "Jump":
                    State = States.Jump;
                    break;
                case "Right":
                    State = States.Right;
                    break;
                case "Left":
                    State = States.Left;
                    break;
                case "Back":
                    State = States.Back;
                    break;
                default:
                    State = States.Idle;
                    break; 
            }
        } else State = States.Jump;
    }

    private enum States
    { 
        Idle,
        Forward,
        Jump,
        Right,
        Left,
        Back
    }
    private States State
    {

        get { return (States)anim.GetInteger("State"); }
        set { anim.SetInteger("State", (int)value); }
    }
}
