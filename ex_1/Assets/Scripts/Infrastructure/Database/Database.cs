using System.IO;

namespace GizmoLab.Infrastructure.Database
{
    public abstract class Database
    {
        #region Functions

        public virtual void SaveData()
        {
        }

        public virtual void LoadData()
        {
        }

        public virtual void SaveData(string path)
        {
        }

        public virtual void LoadData(string path)
        {
        }

        #endregion
    }
}