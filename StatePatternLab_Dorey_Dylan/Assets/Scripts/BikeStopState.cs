using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [02/13/2024]
 * [Handles the logic for the BikeStopState]
 */

public class BikeStopState : MonoBehaviour, IBikeState
{
    //reference to the bike controller script
    private BikeController _bikeController;

    /// <summary>
    /// Handles the bike controller stop state switch
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
        //set the CurrentSpeed of the bike to 0
        _bikeController.CurrentSpeed = 0;
    }
}
