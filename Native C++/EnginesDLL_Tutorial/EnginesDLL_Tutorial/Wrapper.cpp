#include "Wrapper.h"

CheckpointTimeLogger timeLogger;

PLUGIN_API void ResetLogger()
{
	return timeLogger.ResetLogger();
}

PLUGIN_API void SaveCheckPointTime(float RTBC)
{
	return timeLogger.SaveCheckPointTime(RTBC);
}

PLUGIN_API float GetTotalTime()
{
	return timeLogger.GetTotalTime();
}

PLUGIN_API float GetCheckPointTime(int index)
{
	return timeLogger.GetCheckPointTime(index);
}

PLUGIN_API int GetNumCheckpoints()
{
	return timeLogger.GetNumCheckpoints();
}

PLUGIN_API void SaveTimeScore(int score)
{
	return timeLogger.SaveTimeScore(score);
}

PLUGIN_API int GetTimeScore()
{
	return timeLogger.GetTimeScore();
}


