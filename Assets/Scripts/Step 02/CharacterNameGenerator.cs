using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Functions to complete:
/// - Create Names
/// - Set Individual Name
/// - Set Team Character Names
/// </summary>
public class CharacterNameGenerator : MonoBehaviour
{
 
    [Header("Possible first names")]
    private List<string> firstNames = new List<string>(); // a list of all possible first names for us to use.
    [Header("Possible last names")]
    private List<string> lastNames = new List<string>(); // a list of all possible last names for us to use.
    [Header("Possible nicknames")]
    private List<string> nicknames = new List<string>(); // a list of all possible nick names for us to use.


    private void Awake()
    {
        // call the create names function
        CreateNames();
    }

    /// <summary>
    /// Creates a list of names for all our characters to potentially use.
    /// </summary>
    public void CreateNames()
    {
        // So here we would ideally want to be able to add some names to our first names, last names and nick names lists.
        firstNames.Add("Aaron");
        firstNames.Add("Adam");
        firstNames.Add("Saul");

        lastNames.Add("Goss");
        lastNames.Add("Ho");
        lastNames.Add("Alexander");

        nicknames.Add("Conqueror of the Dancefloor");
        nicknames.Add("Graduate of Dance-versity");
        nicknames.Add("Smooth Operator");
    }

    /// <summary>
    /// set a characters name to a random value in our Part 02
    /// </summary>
    /// <param name="character"></param>
    public void SetIndividualCharacter(CharacterName character)
    {
        // So here rather than each character being called Blanky Blank Blank,
        // we probably want it to be a random first,last and nickname


        character.firstName = firstNames[Random.Range(0, firstNames.Count)];
        character.lastName = lastNames[Random.Range(0, lastNames.Count)];
        character.nickName = nicknames[Random.Range(0, nicknames.Count)];
        
        Debug.Log(character);
    }

    /// <summary>
    /// sets a character name for each member of a team, this is in our part 03
    /// </summary>
    /// <param name="namesNeeded"></param>
    /// <returns></returns>
    public void SetTeamCharacterNames(List<CharacterName> teamCharacters)
    {
        // so here we have a list of character names coming in.
        // we should probably loop over that list of character names, and then for each character set their first, last and nickname a random one from our lists

        foreach (CharacterName character in teamCharacters) ;
        Debug.Log("Player: " + teamCharacters);

        // if you want to get fancy you could use another function within this script to help out here.

    }
}