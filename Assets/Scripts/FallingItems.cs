using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingItems : MonoBehaviour
{
    public List<GameObject> _items;

    [SerializeField] private GameObject _item;
    [SerializeField] private Vector3 _forceDirection = new Vector3(0, -1, 0);


    // Spawn object from the ceiling at random location
    public void SpawnObject()
    {
        // set random falling location x and z, y is fixed because we need the height to be at the same position
        float _x = Random.Range(-0.5f, 0.5f);
        float _y = transform.position.y;
        float _z = Random.Range(-0.5f, 0.5f);
        Vector3 temp = new Vector3(_x, _y, _z);
        Debug.Log(temp);
        // add force for creating falling speed
        _item.GetComponent<Rigidbody>().AddForce(_forceDirection); // This doesn't work ;((
        _items.Add(Instantiate(_item, temp, Quaternion.identity)); // and then pop the item!
    }
}