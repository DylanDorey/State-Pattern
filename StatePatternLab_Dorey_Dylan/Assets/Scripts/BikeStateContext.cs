/*
 * Author: [Dorey, Dylan]
 * Last Updated: [02/13/2024]
 * [Sets the state context for the bike]
 */

public class BikeStateContext
{
    //public property for the current state of the bike
    public IBikeState CurrentState
    {
        get; set;
    }

    //private BikeController reference
    private readonly BikeController _bikeController;

    //constructor for BikeController
    public BikeStateContext(BikeController bikeController)
    {
        //initialize _bikeController with the passed in bikeController parameter
        _bikeController = bikeController;
    }

    /// <summary>
    /// Handles the transition of switching the bike controller's state without any parameters
    /// </summary>
    public void Transition()
    {
        //handle the basic state switch
        CurrentState.Handle(_bikeController);
    }

    /// <summary>
    /// Handles the transition of switching the bike controller's state with a state parameter
    /// </summary>
    /// <param name="state"></param>
    public void Transition(IBikeState state)
    {
        //set the new incoming state
        CurrentState = state;

        //apply the state to the bike controller object
        CurrentState.Handle(_bikeController);
    }
}
