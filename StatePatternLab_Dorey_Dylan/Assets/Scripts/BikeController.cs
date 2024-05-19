using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [02/13/2024]
 * [Initializes the context object and the states, and it also triggers state chages]
 */

public class BikeController : MonoBehaviour
{
    //the bikes max speed and turn distance
    public float maxSpeed = 2.0f;
    public float turnDistance = 2.0f;

    //property for the current speed of the bike
    public float CurrentSpeed 
    { 
        get; set; 
    }

    //property for the current turn direction of the bike
    public Direction CurrentTurnDirection
    {
        get; private set;
    }

    //various states of the bike
    private IBikeState _startState, _stopState, _turnState;

    //reference to the context of the bike state
    private BikeStateContext _bikeStateContext;

    private void Start()
    {
        //intialize the Context Obj
        _bikeStateContext = new BikeStateContext(this);

        //initialize the bike state intefaces
        _startState = gameObject.AddComponent<BikeStartState>();
        _stopState = gameObject.AddComponent<BikeStopState>();
        _turnState = gameObject.AddComponent<BikeTurnState>();

        //trigger the context transition
        //we want the bike to be in the Stop State at the start of the game
        _bikeStateContext.Transition(_stopState);
    }

    /// <summary>
    /// Starts the bike controller
    /// </summary>
    public void StartBike()
    {
        //transition the bikes state
        _bikeStateContext.Transition(_startState);
    }

    /// <summary>
    /// Stops the bike controller
    /// </summary>
    public void StopBike()
    {
        //transition the bikes state
        _bikeStateContext.Transition(_stopState);
    }

    /// <summary>
    /// Turns the bike in the in the direction that get passed in as a parameter
    /// </summary>
    /// <param name="direction"> the turning direction </param>
    public void TurnBike(Direction direction)
    {
        //set the turn direction to the direction that was called
        CurrentTurnDirection = direction;

        //transition the bikes state
        _bikeStateContext.Transition(_turnState);
    }
}
