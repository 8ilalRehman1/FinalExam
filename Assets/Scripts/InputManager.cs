using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public static class InputManager 
{
    private static Controls gameControls;
    public static void Init(BallController myPlayer)
    {
        gameControls = new Controls();

        gameControls.Permanent.Enable();

        gameControls.InGame.Start.performed += ctx =>
        {
            myPlayer.ClickToStart();
            Debug.Log("Start!");
            myPlayer.SetClickToChangeAxis();
        };


    }
    public static void SetGameCrontrols()
    {
        gameControls.InGame.Enable();
        gameControls.UI.Disable();
    }

    public static void SetUIControls()
    {
        gameControls.InGame.Disable();
        gameControls.UI.Enable();
    }
}
