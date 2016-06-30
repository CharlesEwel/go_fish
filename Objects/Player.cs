using System.Collections.Generic;
using System;

namespace GoFishVariables.Objects
{
  public class Player
  {

    private int _score;
    private List<int> _hand = new List<int> {};

    public Player()
    {
      _hand = new List<int> {};
      _score = 0;
    }

    public void AddCard(int addCard)
    {
      _hand.Add(addCard);
    }

    public List<int> GetHand()
    {
      return _hand;
    }
  }
}
