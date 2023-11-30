using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTheCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offsetBy = new Vector3(-11, 16, -14);
    private bool ballIsDead = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballIsDead == true)
        {
            transform.position = target.position + offsetBy;
        }
        else transform.position = offsetBy;
    }

    public void StopMovingTheCamera(BallController CameraMoveCheck)
    {
        CameraMoveCheck.BallIsOffTheGround();
        ballIsDead = CameraMoveCheck.BallFellOffCamera;
    }
}
