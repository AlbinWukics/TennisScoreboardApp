using TennisScoreboardApp.Client.Services.Interfaces;
using TennisScoreboardApp.Shared.Enums;

namespace TennisScoreboardApp.Client.Services;

public class TennisScoreService : ITennisScoreService
{
	private TennisScore playerOne = TennisScore.Love;
	private TennisScore playerTwo = TennisScore.Love;

	public TennisScore GetPlayerOneScore()
	{
		return playerOne;
	}

	public TennisScore GetPlayerTwoScore()
	{
		return playerTwo;
	}

	public void IncrementPlayerOneScore()
	{

		if (playerOne == TennisScore.Forty && playerTwo < TennisScore.Forty)
		{
			playerOne = TennisScore.Love;
			playerTwo = TennisScore.Love;
			// Score for playerOne
			return;
		}

		else if (playerOne == TennisScore.Advantage)
		{
			playerOne = TennisScore.Love;
			playerTwo = TennisScore.Love;
			// Score for playerOne
			return;
		}

		else if (playerOne == TennisScore.Deuce && playerTwo == TennisScore.Advantage)
		{
			playerTwo = TennisScore.Deuce;
		}

		else if (playerOne == TennisScore.Deuce && playerTwo == TennisScore.Deuce)
		{
			playerOne = TennisScore.Advantage;
		}

		playerOne = playerOne switch
		{
			TennisScore.Love => TennisScore.Fifteen,
			TennisScore.Fifteen => TennisScore.Thirty,
			TennisScore.Thirty => TennisScore.Forty,
			_ => playerOne
		};

		if (playerOne == TennisScore.Forty && playerTwo == TennisScore.Forty)
		{
			playerOne = TennisScore.Deuce;
			playerTwo = TennisScore.Deuce;
		}
	}

	public void IncrementPlayerTwoScore()
	{
		if (playerTwo == TennisScore.Forty && playerOne < TennisScore.Forty)
		{
			playerOne = TennisScore.Love;
			playerTwo = TennisScore.Love;
			// Score for playerTwo
			return;
		}

		else if (playerTwo == TennisScore.Advantage)
		{
			playerOne = TennisScore.Love;
			playerTwo = TennisScore.Love;
			// Score for playerTwo
			return;
		}

		else if (playerTwo == TennisScore.Deuce && playerOne == TennisScore.Advantage)
		{
			playerOne = TennisScore.Deuce;
		}

		else if (playerTwo == TennisScore.Deuce && playerOne == TennisScore.Deuce)
		{
			playerTwo = TennisScore.Advantage;
		}

		playerTwo = playerTwo switch
		{
			TennisScore.Love => TennisScore.Fifteen,
			TennisScore.Fifteen => TennisScore.Thirty,
			TennisScore.Thirty => TennisScore.Forty,
			_ => playerTwo
		};

		if (playerTwo == TennisScore.Forty && playerOne == TennisScore.Forty)
		{
			playerOne = TennisScore.Deuce;
			playerTwo = TennisScore.Deuce;
		}
	}
}