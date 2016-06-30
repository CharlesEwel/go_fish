using System.Collections.Generic;
using GoFishVariables.Objects;
using Nancy;

namespace GoFishGame
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=>View["index.cshtml"];
      Get["/new_game"]=_=> {
        Game newGame = new Game();
        Player newPlayer1 = new Player();
        Player newPlayer2 = new Player();
        for(int i=1; i<=7; i++)
        {
          newPlayer1.AddCard(newGame.DrawCard());
          newPlayer2.AddCard(newGame.DrawCard());
        }
        newGame.AddPlayer(newPlayer1);
        newGame.AddPlayer(newPlayer2);
        return View["game.cshtml", newGame];
      };
    }
  }
}


@{
  List<string> suits = {clubs, diamonds, hearts, spades};
  List<string> ranks = {Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King};
  List <string> deck = {};
    for(int i=0; i<=suits.Count-1; i++)
    {
      for(int j=0; j<=suits.Count-1; j++)
      {
        deck.Add(ranks[j]+" of "+suits[i]);
      }
    }
}
