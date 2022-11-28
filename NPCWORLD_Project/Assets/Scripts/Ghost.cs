using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Agent
{
    protected override void CalculateSteeringForces()
    {
        Wander();
        Seperate(AgentManager.Instance.tagPlayers);
        StayInBounds(3f);

        AvoidAllObstacles();
    }
}
