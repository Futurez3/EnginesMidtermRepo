#pragma once
#include "CheckpointTimeLogger.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Functions in here

	//Reset the logger
	PLUGIN_API void ResetLogger();

	//Save most recent Checkpoint time
	PLUGIN_API void SaveCheckPointTime(float RTBC);

	//Total Time for Race.
	PLUGIN_API float GetTotalTime();
	//Get Index
	PLUGIN_API float GetCheckPointTime(int index);

	PLUGIN_API int GetNumCheckpoints();


#ifdef __cplusplus
}
#endif