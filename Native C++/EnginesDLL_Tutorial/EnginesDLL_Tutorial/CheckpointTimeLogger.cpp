#include "CheckpointTimeLogger.h"

void CheckpointTimeLogger::ResetLogger()
{
    m_RTBC.clear();
    m_TRT = 0.0f;
    m_score = 0;
}

void CheckpointTimeLogger::SaveCheckPointTime(float RTBC)
{
    m_RTBC.push_back(RTBC);
    m_TRT += RTBC;
}

float CheckpointTimeLogger::GetTotalTime()
{
    return m_TRT;
}

float CheckpointTimeLogger::GetCheckPointTime(int index)
{
    return m_RTBC[index];
}

int CheckpointTimeLogger::GetNumCheckpoints()
{
    return m_RTBC.size();
}

void CheckpointTimeLogger::SaveTimeScore(int score)
{
    m_score = score;
}

int CheckpointTimeLogger::GetTimeScore()
{
    return m_score;
}
