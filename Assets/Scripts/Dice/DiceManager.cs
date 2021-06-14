using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceManager : MonoBehaviour
{
    public List<GameObject> dices;
    public GameObject Button;
    public Text DiceText;
    public CameraManager cm;
    public WaypointMovement wpm;
    public RoundManager roundManager;

    float dirX;
    float dirY;
    float dirZ;

    public void ThrowDices()
    {
        Button.SetActive(false);
        cm.SetDiceCamera();

        foreach (GameObject die in dices)
        {
            dirX = Random.Range(0, 500);
            dirY = Random.Range(0, 500);
            dirZ = Random.Range(0, 500);
            
            die.transform.position = transform.position;
            die.transform.Rotate(dirX, dirY, dirZ);

            die.GetComponent<Rigidbody>().AddForce(die.transform.up * 200);

            die.SetActive(true);
        }

        StartCoroutine(DeleteDiceCoroutine());
    }

    IEnumerator DeleteDiceCoroutine()
    {
        yield return new WaitForSeconds(3);

        //This Should be it's own class, on update chech if both dice are rolled
        int diceNumber = 0;
        foreach (GameObject die in dices)
        {
            diceNumber += die.GetComponent<Die_d6>().value;
        }
        DiceText.text = "Speler 1 heeft " + diceNumber + " gegooid!";
        wpm.moveTo += diceNumber;
        cm.SetPlayerCamera(0);

        yield return new WaitForSeconds(4);

        foreach (GameObject die in dices)
        {
            die.SetActive(false);
            die.SetActive(false);
        }

        DiceText.text = "";
        cm.SetPlayboardCamera();

        yield return new WaitForSeconds(2);

        roundManager.setGameStartStart();
    }
}
