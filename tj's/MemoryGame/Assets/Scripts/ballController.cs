using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour

  {

    public GameObject particle; 
    [SerializeField]
    private float speed;
    bool started;
    bool gameOver;
    Rigidbody rb;

   void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Start is called before the first frame update
    void Start()
    {
        started = false;
        gameOver = false;

    }

    // Update is called once per frame
    void Update()
 {

    if(Application.platform == RuntimePlatform.Android){
         if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                GameManager1.instance.StartGame();
            }
        }

    }
    else{
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                GameManager1.instance.StartGame();
            }
        }
        }

        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        if(! Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
            rb.velocity = new Vector3(0, -25f, 0);

            Camera.main.GetComponent<CameraFollow>().gameOver = true;

            GameManager1.instance.GameOver();
        }

        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDirection();
        }
        
    }
    void SwitchDirection()
    {
        if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed,0,0);
        }
        else if(rb.velocity.x > 0){
            rb.velocity = new Vector3 (0, 0, speed);

        }
       
    }
    private void OnTriggerEnter(Collider col)
    {
        GameObject part = Instantiate(particle, col.gameObject.transform.position, Quaternion.identity) as GameObject;
        Destroy(col.gameObject);
        Destroy(part, 1f);

    }
   


}
    