namespace GizmoLab.Gameplay
{
    public interface IPlayerData
    {
        Weapon Weapon
        {
            get;
        }
        float Health
        {
            get;
            set;
        }

        int Score
        {
            get;
            set;
        }
    }
}