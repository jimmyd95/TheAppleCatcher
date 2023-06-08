using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcherController : MonoBehaviour
{
    [SerializeField] private GameObject _appleGeneratorField;
    [SerializeField] private int _fallingAppleAmount = 10;

    private bool _paused = false; // set the game to 
    private List<GameObject> _apples;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StopTime();
    }

    public void DroppingApples()
    {
        float temp = Random.Range(0, 3);
        float ran_apples = Random.Range(3,10);
        for (int i = 0; i < ran_apples; i++)
        {
            Invoke(nameof(GenerateApple), temp);
        }
    }

    // Calls the FaillingItem script and spawn an apple with gravity there
    void GenerateApple()
    {
        _appleGeneratorField.GetComponent<FallingItems>().SpawnObject(); // spawn the apple
    }

    private void OnDestroy()
    {
        if (_appleGeneratorField == null) return;

        var temp = _appleGeneratorField.GetComponent<FallingItems>()._items;
        // run a for loop to check if there's anything inside the array
        foreach (var item in temp)
            if (item) // if there are items, destory it
                Destroy(item);

        temp.Clear(); // clean out the array
    }

    public void SwitchPause()
    {
        _paused = !_paused;
    }

    // stop time depends on if pause has been triggered
    // This stops time.deltatime, but it does not stop anything in fixedUpdate
    private void StopTime()
    {
        if (_paused)
        {
            Debug.Log("Time paused");
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Unpaused");
            Time.timeScale = 1;
        }
    }
}
