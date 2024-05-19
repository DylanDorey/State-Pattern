using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [02/13/2024]
 * [Handles the logic for the BikeStartState]
 */

public class BikeStartState : MonoBehaviour, IBikeState
{
    //reference to the bike controller script
    private BikeController _bikeController;

    /// <summary>
    /// Handles the bike controller start state switch
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

        //simple implementation examples*
        //set the speed of the bike to the max speed
        _bikeController.CurrentSpeed = _bikeController.maxSpeed;
    }

    void Update()
    {
        //if bikeController is initialized
        if (_bikeController)
        {
            //if the bikes current speed is greater than 0
            if(_bikeController.CurrentSpeed > 0)
            {
                //move the bike bike forward by the current speed
                _bikeController.transform.Translate(Vector3.forward * (_bikeController.CurrentSpeed * Time.deltaTime));
            }
        }
    }
}
