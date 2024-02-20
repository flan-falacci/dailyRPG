using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class combatManager : MonoBehaviour
{
    public Canvas myUI; 

    public Text actionboxTitle;

    public Button waterButton;
    public Button fireButton;
    public Button grassButton;

    public Button defendButton;
    public Button healButton;

    Dictionary<string, int> player1 = new Dictionary<string,int>();
    Dictionary<string, int> player2 = new Dictionary<string, int>();
    Dictionary<string, int> player3 = new Dictionary<string, int>();

    Dictionary<string, int> enemy = new Dictionary<string, int>();

    //moves
    List<string> player1moves = new List<string>();
    List<string> player2moves = new List<string>();
    List<string> player3moves = new List<string>();

    List<string> enemymoves = new List<string>(); 

    //turn selection bools
    bool player1turn;
    bool player2turn;
    bool player3turn;

    //combat turn bools
    bool player1acting;
    bool player2acting;
    bool player3acting;
    bool enemyacting; 

    // Start is called before the first frame update
    void Start()
    {
        //player 1 stats 
        player1.Add("STR", 5);
        player1.Add("DEF", 5);
        player1.Add("MAXHP", 25);
        player1.Add("CURRENT_HP", 25);
        player1.Add("TYPE", 1);
        player1.Add("SPD", 10);

        //player 2 stats 
        player2.Add("STR", 3);
        player2.Add("DEF", 10);
        player2.Add("MAXHP", 30);
        player2.Add("CURRENT_HP", 30);
        player2.Add("TYPE", 2);
        player2.Add("SPD", 5);

        //player 3 stats 
        player3.Add("STR", 8);
        player3.Add("DEF", 3);
        player3.Add("MAXHP", 20);
        player3.Add("CURRENT_HP", 20);
        player3.Add("TYPE", 3);
        player3.Add("SPD", 15);

        //enemy stats
        enemy.Add("STR", 5);
        enemy.Add("DEF", 5);
        enemy.Add("MAXHP", 50);
        enemy.Add("CURRENT_HP", 50);
        enemy.Add("TYPE", 1);
        enemy.Add("SPD", 6);
        enemy["SPD"] = 6; 

        actionboxTitle.text = "player 1"; 

        //start with player1
        player1turn = true;
        player2turn = false;
        player3turn = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (player1["CURRENT_HP"] <= 0)
        {

        }

        //changing the actionbox title
        //disable moves from being added to queue after 5th move
       if ((player1moves.Count >= 5) && (player2moves.Count < 5))
        {
            actionboxTitle.text = "player 2";
            player1turn = false;
            player2turn = true;
            player3turn = false;
        }
       if ((player2moves.Count >= 5)&& (player3moves.Count < 5))
        {
            actionboxTitle.text = "player 3";
            player1turn = false;
            player2turn = false;
            player3turn = true; 
        }
       if (player3moves.Count>= 5)
        {
            //create enemy move list 
            enemymoves.Add("water attack");
            enemymoves.Add("fire attack");
            enemymoves.Add("grass attack");
            enemymoves.Add("water attack");
            enemymoves.Add("fire attack");

            //begin combat 
            DoMoves(); 

            //turn off menu 
            myUI.gameObject.SetActive(false);
        }

    }
    //button functionalities 
    public void WaterButton()
    {
        if (player1turn)
        {
            player1moves.Add("water attack");
        }
        else if (player2turn)
        {
            player2moves.Add("water attack");
        }else if (player3turn)
        {
            player3moves.Add("water attack");
        }
    }
    public void FireButton()
    {
        if (player1turn)
        {
            player1moves.Add("fire attack");
        }
        else if (player2turn)
        {
            player2moves.Add("fire attack");
        }
        else if (player3turn)
        {
            player3moves.Add("fire attack");
        }
    }
    public void GrassButton()
    {
        if (player1turn)
        {
            player1moves.Add("grass attack");
        }
        else if (player2turn)
        {
            player2moves.Add("grass attack");
        }
        else if (player3turn)
        {
            player3moves.Add("grass attack");
        }
    }
    public void DefendButton()
    {
        if (player1turn)
        {
            player1moves.Add("defend");
        }
        else if (player2turn)
        {
            player2moves.Add("defend");
        }
        else if (player3turn)
        {
            player3moves.Add("defend");
        }
    }
    public void HealButton()
    {
        if (player1turn)
        {
            player1moves.Add("heal");
        }
        else if (player2turn)
        {
            player2moves.Add("heal");
        }
        else if (player3turn)
        {
            player3moves.Add("heal");
        }
    }

    //moves
    public void WaterAttack()
    {
        if //enemy type = fire 
            //super effective damage

        else //enemy type != fire
            //regular damage 

        //change this unit's type to water
    }
    public void FireAttack()
    {
        if //enemy type = grass 
            //super effective damage

        else //enemy type != grass
            //regular damage 

        //change this units type to fire
    }
    public void GrassAttack()
    {
        if //enemy type = water 
            //super effective damage

        else //enemy type != water
            //regular damage 

        //change this unit's type to grass 
    }
    public void Defend()
    {
        //get active unit 
        //this unit DEF is raised by x until it uses another move
    }
    public void Heal()
    {
        //get active unit
        //this unit gets +x HP 
    }

    //translating from move names to move functions
    private void DoMoves()
    {
       //know active player
       //get the next move in player's queue
       //call the moves function (passing it the active player)
       //switch active player to next in the queue 
    }
}

