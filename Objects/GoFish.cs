using System.Collections.Generic;
using System;

namespace GoFishVariables.Objects
{
  public class Game
  {
    private List<int> _cards;
    private List<Player> _players;
    public Game (){
      _cards = new List<int> {};
      _players = new List<Player> {};
      for(int i=1; i<=52; i++)
      {
        _cards.Add(i);
      }
      Random r = new Random();
      int randomIndex = 0;
      List<int> randomList= new List<int> {};
      while (_cards.Count > 0)
      {
        randomIndex = r.Next(0, _cards.Count); //Choose a random object in the list
        randomList.Add(_cards[randomIndex]); //add it to the new, random list
        _cards.RemoveAt(randomIndex); //remove to avoid duplicates
      }
      _cards=randomList;
    }
    public List<int> GetCards()
    {
      return _cards;
    }
    public List<Player> GetPlayers()
    {
      return _players;
    }
    public int DrawCard()
    {
      int drawnCard=_cards[0];
      _cards.Remove(drawnCard);
      return drawnCard;
    }
    public void AddPlayer(Player newPlayer)
    {
      _players.Add(newPlayer);
    }
  }
}
