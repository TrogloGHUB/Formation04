using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int nb_vies;
    public GameObject player;
    public GameObject vies;
    private Text vies_text;

    // Start is called before the first frame update
    void Start()
    {
        vies_text = vies.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        vies_text.text = "Vies : " + nb_vies.ToString();
        if (player.transform.position.y < -5)
        {
            Destroy(player);
            nb_vies--;
            if (nb_vies < 1)
            {
                Debug.Log("GAME OVER");
            }
            else
            {
                Vector3 Pos = new Vector3(0, 0.094f, 0);
                Instantiate(player, Pos, player.transform.rotation);
            }
        }

    }
}
