using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private Sprite bgImage;

    public Sprite[] puzzles;
    public List<Sprite> gamePuzzles = new List<Sprite>();

    private bool firstGuess, secondGuess;
    public List<Button> btns = new List<Button>();

    private int countGuess, CountCorectGuesses, gameGuesses, firstGuessIndex, secondGuessIndex;
    private string firstGuessPuzzle, secondGuessPuzzle;

    private bool facingR = true;

    void Awake()
    {
        puzzles = Resources.LoadAll<Sprite>("Sprites/animal");
    }
    void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        gameGuesses = gamePuzzles.Count / 2;
        shuffle(gamePuzzles);
    }
    public void flip()
    {
        facingR = !facingR;
        transform.Rotate(Vector3.up * 180);
    }

    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for (int i = 0; i < objects.Length; i++)
        {

            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }

    }
    // Start is called before the first frame update

    //adding image on flip side 
    void AddGamePuzzles()
    {

        int looper = btns.Count;
        int index = 0;

        for (int i = 0; i < looper; i++)
        {

            if (index == looper / 2)
            {
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);

            index++;

        }
    }

    //adding listerners
    void AddListeners(){
        foreach (Button btn in btns){
            btn.onClick.AddListener(() => PickAPuzzle());
            flip();
        }
    }

    //executeing listeners
    public void PickAPuzzle(){
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if (!firstGuess)
        {
            firstGuess = true;
            firstGuessIndex = int.Parse(name);

            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;

            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];



        }
        else if (!secondGuess){
            secondGuess = true;
            secondGuessIndex = int.Parse(name);
            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];

            if (firstGuessPuzzle == secondGuessPuzzle){
               Debug.Log("puzzles match");
            }
            else{
                Debug.Log("puzzles dont match");
            }
            countGuess++;
            StartCoroutine(checkIfThePuzzlesMatch());
        }

    }

    IEnumerator checkIfThePuzzlesMatch(){
        yield return new WaitForSeconds(1f);
        //if we guess correctly 
            if (firstGuessPuzzle == secondGuessPuzzle)
            {
                yield return new WaitForSeconds(.5f);
                //buttons wotn be touchable anymore
                btns[firstGuessIndex].interactable = false;
                btns[secondGuessIndex].interactable = false;
                //we cant see the button anymore
                btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
                btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);
                checkIfGameIsFinished();
            }
            else{
                //flip tiles back if guess is round
                //wait half a sec before turning  
                yield return new WaitForSeconds(.5f);
                btns[firstGuessIndex].image.sprite = bgImage;
                btns[secondGuessIndex].image.sprite = bgImage;
            }
        yield return new WaitForSeconds(.5f);
        firstGuess = secondGuess = false;
    }
    void checkIfGameIsFinished(){
        CountCorectGuesses++;
        if (CountCorectGuesses == gameGuesses)
        {
            Debug.Log("GAmefinished");
            Debug.Log("it took yoo  " + countGuess + " guess to finsih the game");
        }
    }
    //randomixing the cards 
        void shuffle(List<Sprite> list){
            for (int i = 0; i < list.Count; i++){
                Sprite temp = list[i];
                int randomIndex = Random.Range(i, list.Count);
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }
        }
}