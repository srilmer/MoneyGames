using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    public List<Transform> waypoints;
    public int moveTo;
    public RigidbodyController rbController;
    public float epsilonTarget;
    public List<Die> dies;

    private int waypointTargetIndex;

    private void Start()
    {
        waypointTargetIndex = 0;      
    }

    private void Update()
    {
        if (IsWaypointReached())
        {
            if(!isTileReached())
            SwitchToNextWayPoint();
        }
        MoveTowardsWaypointTarget();
    }

    public void setMoveto(int value)
    {
        this.moveTo += value;
    }

    private bool IsWaypointReached()
    {
        Vector3 myPosition = rbController.GetPosition();
        Vector3 targetPosition = GetWaypointTargetPosition();

        float distanceToTarget = Vector3.Distance(myPosition, targetPosition);
        return distanceToTarget < epsilonTarget;
    }

    private bool isTileReached()
    {
        Vector3 myPosition = rbController.GetPosition();
        Vector3 targetPosition = waypoints[moveTo].position;

        float distanceToTarget = Vector3.Distance(myPosition, targetPosition);

        return distanceToTarget < epsilonTarget;
    }

    private void SwitchToNextWayPoint()
    {
        waypointTargetIndex++;
        if (waypointTargetIndex >= waypoints.Count)
            waypointTargetIndex = 0;
    }

    private void MoveTowardsWaypointTarget()
    {
        Vector3 myPosition = rbController.GetPosition();
        Vector3 targetPosition = GetWaypointTargetPosition();

        Vector3 movement = targetPosition - myPosition;
        rbController.Move(movement);
    }

    private Vector3 GetWaypointTargetPosition()
    {
        return waypoints[waypointTargetIndex].position;
    }
}
