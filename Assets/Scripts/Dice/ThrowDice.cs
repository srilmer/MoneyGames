using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowDice : MonoBehaviour
{
    public List<GameObject> dices;
    public GameObject Button;
    public Text DiceText;
    public List<GameObject> camaras;

    float dirX;
    float dirY;
    float dirZ;

    public void ThrowDices()
    {
        Button.SetActive(false);

        //Reminder Make CameraHandler Class
        camaras[0].SetActive(false);
        camaras[1].SetActive(true);

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
        DiceText.text = "You Threw " + diceNumber + "!";

        yield return new WaitForSeconds(4);

        foreach (GameObject die in dices)
        {
            die.SetActive(false);
            die.SetActive(false);
        }

        DiceText.text = "";
        camaras[1].SetActive(false);
        camaras[0].SetActive(true);
        Button.SetActive(true);
    }
}
