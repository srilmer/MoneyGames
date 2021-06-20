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
    public bool isFirstRound = true;
    public GameObject SalaryUI;

    private int waypointTargetIndex;
    public Canvas investeren;

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

    private void OnCollisionEnter(Collision collision)
    {
        if(moveTo != 0)
        transform.Rotate(Vector3.up * 2000);
        if (collision.gameObject.CompareTag("StartingTile") && !isFirstRound)
        {
            SalaryUI.SetActive(true);

            if(moveTo != 0)
            isFirstRound = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("StartingTile") && !isFirstRound)
        {
            isFirstRound = true;
            StartCoroutine(SpawnInvesteren());
        }
    }

    IEnumerator SpawnInvesteren()
    {
        yield return new WaitForSeconds(3f);

        Instantiate(investeren); 
    }

    public void setMoveto(int value)
    {

        if(this.moveTo + value >= 27)
        {
            isFirstRound = false;
            int temp = this.moveTo + value;
            this.moveTo = (temp - 28);
            if(this.moveTo <0)
            {
                this.moveTo = 0;
            }
        }
        else
        {
            this.moveTo += value ;
        }
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
