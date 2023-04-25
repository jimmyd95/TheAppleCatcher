using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcherController : MonoBehaviour
{
    public bool _paused = false; // set the game to 

    [SerializeField] private GameObject _appleGeneratorField;
    [SerializeField] private int _fallingAppleAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StopTime();
    }

    public void GameStart()
    {
        // generate x amount of apples when called this function
        for (int i = 0; i < _fallingAppleAmount; i++)
        {
            //float time = Random.Range(0, 100); // set a random wait time for each apple to fall
            //WaitForCertainPeriod(time); // wait for the time
            _appleGeneratorField.GetComponent<FallingItems>().SpawnObject(); // spawn the apple
        }
    }

    // Set a wait time
    public IEnumerator WaitForCertainPeriod(float time)
    {
        Debug.Log("Dropping in " + time + " seconds");
        yield return new WaitForSeconds(time);
    }

    // stop time depends on if pause has been triggered
    // This stops time.deltatime, but it does not stop anything in fixedUpdate
    private void StopTime()
    {
        if (_paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
