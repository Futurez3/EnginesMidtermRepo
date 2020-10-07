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

private:

	float m_TRT = 0.0f;

	std::vector<float> m_RTBC;

};

