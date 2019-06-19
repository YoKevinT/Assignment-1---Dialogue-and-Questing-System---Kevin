using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueQuest : MonoBehaviour
{
    // Dialogue Variables
    public GameObject DialoguePanel;
    public GameObject QuestPanel;
    public Text DialogueText;
    public GameObject Meh;
    public GameObject Yes;
    public GameObject Bye;
    public GameObject No;

    // Quest Variables
    public GameObject CloseQuest;
    public GameObject OpenQuest;
    public GameObject TheQuest;
    public GameObject CongratulationPanel;
    public GameObject ClaimReward;
    public GameObject Reward;
    public Slider LevelSlider;
    public GameObject CloseGame;

    // Show text and hide both buttoms (Function for the player that says Yes or Meh)
    public void DialogueOptions(string word)
    {
        DialogueText.text = word;
        Meh.SetActive(false);
        Yes.SetActive(false);
        Bye.SetActive(true);
        No.SetActive(false);
    }

    // Hide the Panel and Button (Function for the player that says Bye)
    public void CloseOptionsQuest()
    {
        DialoguePanel.SetActive(false);
        QuestPanel.SetActive(true);
        CloseQuest.SetActive(true);
        OpenQuest.SetActive(false);
        TheQuest.SetActive(true);
    }

    // Hide the Panel (Function for the player that says No)
    public void CloseOptions()
    {
        DialoguePanel.SetActive(false);
        CloseQuest.SetActive(false);
        OpenQuest.SetActive(false);
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Closing the Game in Unity
#endif
            Application.Quit(); // Close the Game
    }

    // Show QuestPanel
    public void openQuest()
    {
        QuestPanel.SetActive(true);
        CloseQuest.SetActive(true);
        OpenQuest.SetActive(false);
        TheQuest.SetActive(true);
    }

    // Hide QuestPanel
    public void closeQuest()
    {
        QuestPanel.SetActive(false);
        CloseQuest.SetActive(false);
        OpenQuest.SetActive(true);
        TheQuest.SetActive(false);
    }

    // Show obly the Quest
    public void theQuest()
    {
        TheQuest.SetActive(false);
        CloseQuest.SetActive(false);
        QuestPanel.SetActive(false);
        ClaimReward.SetActive(true);
        CongratulationPanel.SetActive(true);
    }

    // Show only the Reward
    public void claimReward()
    {
        ClaimReward.SetActive(false);
        Reward.SetActive(true);
        CongratulationPanel.SetActive(false);
        LevelSlider.value = 0.5f;
        CloseGame.SetActive(true);
    }
}