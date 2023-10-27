using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportHandler : MonoBehaviour
{
    public List<Transform> teleports;
    public Image blackScreen;
    
    private int currentTeleport = 0;
    private bool teleporting = false;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !teleporting) 
            StartCoroutine(Teleport());

        if (teleporting) blackScreen.color = Color.Lerp(blackScreen.color, Color.black, 5 * Time.deltaTime);
        else blackScreen.color = Color.Lerp(blackScreen.color, Vector4.zero, 5 * Time.deltaTime);
    }

    private IEnumerator Teleport() 
    {
        teleporting = true;
        currentTeleport += 1;
        if (currentTeleport > teleports.Count) currentTeleport = 0;

        yield return new WaitForSeconds(1);

        transform.position = teleports[currentTeleport].position;
        teleporting = false;
    }
}
