using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerPosition : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    [SerializeField] float _dotResult;

    // Update is called once per frame
    void Update()
    {
        var distanceToPlayer = playerPosition.position - transform.position;
        var distanceLength = Mathf.Sqrt(distanceToPlayer.x * distanceToPlayer.x
            + distanceToPlayer.y * distanceToPlayer.y
            + distanceToPlayer.z * distanceToPlayer.z);

        var distanceToPlayerNormalized = new Vector3(distanceToPlayer.x / distanceLength,
            distanceToPlayer.y / distanceLength,
            distanceToPlayer.z / distanceLength);

        _dotResult = (distanceToPlayerNormalized.x * transform.right.x
            + distanceToPlayerNormalized.y * transform.right.y
            + distanceToPlayerNormalized.z * transform.right.z);

        if(_dotResult > 0)
        {
            Debug.Log("Right");
        }
        else if (_dotResult < 0)
        {
            Debug.Log("Left");
        } 
        else
        {
            Debug.Log("Ahead or behind");
        }
    }
}
