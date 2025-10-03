using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class LevelTime : LevelCondition
{
    private float m_time;
    private int _displayTime;
    private GameManager m_mngr;
    private StringBuilder sb = new StringBuilder();

    public override void Setup(float value, Text txt, GameManager mngr)
    {
        base.Setup(value, txt, mngr);

        m_mngr = mngr;
        m_time = value;
        _displayTime = (int)value;
        UpdateText();
    }

    private void Update()
    {
        if (m_conditionCompleted) return;

        if (m_mngr.State != GameManager.eStateGame.GAME_STARTED) return;
        //TODO: fix countdown time
        m_time -= Time.deltaTime;
        int timePresent = (int)m_time;
        if (timePresent < _displayTime)
        {
            _displayTime = timePresent;
            UpdateText();
        }

        if (m_time <= -1f)
        {
            OnConditionComplete();
        }
    }

    protected override void UpdateText()
    {
        if (m_time < 0f) return;
        sb.Clear();
        sb.Append("TIME:\n");
        if (_displayTime >= 60)
        {
            sb.Append(_displayTime / 60);
            sb.Append(":");
        }
        sb.Append(_displayTime % 60);
        m_txt.text = sb.ToString();
    }
}