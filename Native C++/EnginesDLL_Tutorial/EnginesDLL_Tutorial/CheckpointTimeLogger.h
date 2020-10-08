#pragma once
#include "PluginSettings.h"

#include <vector>

class PLUGIN_API CheckpointTimeLogger
{
public:

	void ResetLogger();

	void SaveCheckPointTime(float RTBC);

	float GetTotalTime();
	float GetCheckPointTime(int index);
	int GetNumCheckpoints();

	void SaveTimeScore(int score);
	int GetTimeScore();

private:

	float m_TRT = 0.0f;
	int m_score = 0;

	std::vector<float> m_RTBC;

};

