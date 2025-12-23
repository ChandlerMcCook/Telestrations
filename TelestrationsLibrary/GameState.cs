using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;
public class GameState
{
    private int _round = 0;
    private int _roundResponses = 0;
    private bool _isEven = false;
    private List<(uint creatorId, List<ClientAction> promptActions)> _playerPrompts = [];
    
    public List<Player> Players { get; set; }

    public GameState(List<Player> players)
    {
        Players = players;
        _isEven = Players.Count % 2 == 0;
        foreach (var p in Players)
        {
            _playerPrompts.Add((
                p.ID,
                new List<ClientAction>()
            ));
        }
    }

    private int GetCurrentPlayerIndex(uint playerID)
    {
        return (_playerPrompts.FindIndex(tup => tup.creatorId == playerID) + _round) % Players.Count;
    }

    private bool PlayerAlreadyPlayed(uint playerID)
    {
        return _playerPrompts[GetCurrentPlayerIndex(playerID)].promptActions.Count > _round;
    }

    private List<ClientAction> GetCurrentPromptList(uint playerID)
    {
        return _playerPrompts[GetCurrentPlayerIndex(playerID)].promptActions;
    }

    private ClientAction GetLatestAction(uint playerID)
    {
        return GetCurrentPromptList(playerID)[^1];
    }

    public ServerAction GetNextAction(uint playerID)
    {
        ServerAction action;
        if (PlayerAlreadyPlayed(playerID))
        {
            action = new ServerAction(ActionType.Wait);
        } 
        else if (_round == 0)
        {
            action = (_isEven) 
                ? new ServerAction(ActionType.CreateAndDraw) 
                : new ServerAction(ActionType.Create);
        } 
        else if (GetLatestAction(playerID).Drawing is not null)
        {
            action = new ServerAction(ActionType.Guess, Drawing: GetLatestAction(playerID).Drawing);
        }
        else
        {
            action = new ServerAction(ActionType.Draw, Guess: GetLatestAction(playerID).Guess);
        }

        return action;
    }

    public bool SaveAction(uint playerID, ClientAction action)
    {
        if (PlayerAlreadyPlayed(playerID))
        {
            return false; 
        }
        
        if (_round == 0 && _isEven)
        {
            ClientAction guessAction = new ClientAction(Guess: action.Guess);
            ClientAction drawAction = new ClientAction(Drawing: action.Drawing);
            GetCurrentPromptList(playerID).Add(guessAction);
            GetCurrentPromptList(playerID).Add(drawAction);
            _roundResponses++;
            if (_roundResponses == Players.Count)
            {
                _round = 2;
                _roundResponses = 0;
            }
            return true;
        }

        GetCurrentPromptList(playerID).Add(action);
        _roundResponses++;
        if (_roundResponses == Players.Count)
        {
            _round++;
            _roundResponses = 0;
        }

        return true;
    }
}
