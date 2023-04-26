using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingItems : MonoBehaviour
{
    [SerializeField] private GameObject _item;
    [SerializeField] private float _gravity = 1;

    // Spawn object from the ceiling at random location
    public void SpawnObject()
    {
        var targetRigidbody = _item.GetComponent<Rigidbody>();
        // set random falling location x and z, y is fixed because we need the height to be at the same position
        float _x = Random.Range(0, 5);
        float _y = transform.position.y;
        float _z = Random.Range(0, 5);
        Vector3 temp = new Vector3(_x, _y, _z);
        Debug.Log(temp);
        // add force for creating falling speed
        //targetRigidbody.AddForce(new Vector3(0, -1, 0) * _gravity);
        Instantiate(_item, temp, Quaternion.identity); // and then pop the item!
    }

    private void OnDestroy()
    {
        Destroy(_item);
    }
}