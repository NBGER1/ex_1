using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Infrastructure.Database
{
    public interface IDataManagement
    {
        #region Functions

        public void SaveData();

        public void LoadData();

        #endregion
    }
}