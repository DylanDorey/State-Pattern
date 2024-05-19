using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [02/13/2024]
 * [Handles the logic for the BikeTurnState]
 */

public class BikeTurnState : MonoBehaviour, IBikeState
{
    //The desired turn direction
    private Vector3 _turnDirection;

    //reference to the bike controller script
    private BikeController _bikeController;

    /// <summary>
    /// Handles the bike controller turn state switch
    /// </summary>
    /// <param name="bikeController"> the bike controller that is changing states </param>
    public void Handle(BikeController bikeController)
    {
        //if bikeController is empty/null
        if (!_bikeController)
        {
            //initialize bikeController to the incoming/passed in bikeContoller
            _bikeController = bikeController;
        }

        //simple implementation examples
        //set the turnDirection of the bike to the current turn direction casted as a float
        _turnDirection.x = (float)_bikeController.CurrentTurnDirection;

        //if the bikes current speed is greater than 0
        if (_bikeController.CurrentSpeed > 0)
        {
            //move the bike bike in the desired turn direction by the bikeController's turn distance
            transform.Translate(_turnDirection * _bikeController.turnDistance);
        }
    }
}
