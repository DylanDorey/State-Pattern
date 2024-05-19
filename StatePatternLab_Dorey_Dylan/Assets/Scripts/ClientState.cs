using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [02/13/2024]
 * [sets bike controller to the bike controller in the scene]
 */

public class ClientState : MonoBehaviour
{
    //reference to the bike controller script
    private BikeController _bikeController;

    void Start()
    {
        //initialize bikeController to the object in the scene of type BikeController (cast as BikeController to triple confirm it is a BikeController)
        _bikeController = (BikeController)FindObjectOfType(typeof(BikeController));
    }

    /// <summary>
    /// TESTING PURPOSES ONLY ( DO NOT USE IN PRODUCTION CODE ) EXTREMELY INEFFICIENT
    /// </summary>
    private void OnGUI()
    {
        //start bike button
        if (GUILayout.Button("Start Bike"))
        {
            //if pressed start the bike by calling the StartBike method from the bikeController script
            _bikeController.StartBike();
        }

        //turn left button
        if (GUILayout.Button("Turn Left"))
        {
            //if pressed turn left by calling the TurnBike method from the bikeController script
            _bikeController.TurnBike(Direction.Left);
        }

        //turn right button
        if (GUILayout.Button("Turn Right"))
        {
            //if pressed turn right by calling the TurnBike method from the bikeController script
            _bikeController.TurnBike(Direction.Right);
        }

        //stop bike button
        if (GUILayout.Button("Stop Bike"))
        {
            //if pressed stop the bike by calling the StopBike method from the bikeController script
            _bikeController.StopBike();
        }
    }
}
