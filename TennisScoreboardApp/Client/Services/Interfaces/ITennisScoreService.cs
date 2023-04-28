using TennisScoreboardApp.Shared.Enums;

namespace TennisScoreboardApp.Client.Services.Interfaces;

public interface ITennisScoreService
{
	TennisScore GetPlayerOneScore();
	TennisScore GetPlayerTwoScore();
	void IncrementPlayerOneScore();
	void IncrementPlayerTwoScore();
}