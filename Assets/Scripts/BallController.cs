using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed = 20;

    [SerializeField] private Rigidbody BallsRigidBody;

    private bool ClickyToStarty;

    private bool ClickToChangeAxis;

    public bool BallFellOffCamera;

    public float movez;

    public float movex;


    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.SetGameCrontrols();
        BallsRigidBody = GetComponent<Rigidbody>();
        movex = 1;
        movez = 1;
    }
    // Update is called once per frame
    void Update()
    {

        if (ClickyToStarty == true) 
        {
            if (!ClickToChangeAxis)
            {
                movez = movez + 0.1f;
                print(ClickToChangeAxis);
                transform.position = new Vector3 (transform.position.x,transform.position.y,movez);
            }
            else
            {
                movex = movex + 0.1f;
                print(ClickToChangeAxis);
                transform.position = new Vector3(movex, transform.position.y, transform.position.z);

            }
        }

    }
    public void ClickToStart()
    {
        ClickyToStarty = true;
    }

    public void SetClickToChangeAxis()
    {
        ClickToChangeAxis = !ClickToChangeAxis;
        print("AxisChange");
        print(ClickToChangeAxis);
    }

    public void BallIsOffTheGround()
    {
        BallFellOffCamera = true;
    }

    private void OnCollisionExit(Collision other)
    {
        BallIsOffTheGround();
    }
}
