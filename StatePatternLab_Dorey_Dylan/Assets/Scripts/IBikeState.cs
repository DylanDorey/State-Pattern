/*
 * Author: [Dorey, Dylan]
 * Last Updated: [02/13/2024]
 * [IBikeState interface instances must implement Handle()]
 */

/// <summary>
/// IBikeState interface instances must implement Handle()
/// </summary>
public interface IBikeState
{
    //Passing an instance of BikeController in the Handle function
    //This approach permits state classes to access the public properties of BikeController
    //this is a deviation of a traditional State Pattern, as usually its the Contact Object
    //that gets passed to the states
    void Handle(BikeController controller);
}
