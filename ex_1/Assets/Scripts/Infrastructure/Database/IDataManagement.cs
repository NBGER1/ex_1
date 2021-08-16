using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Infrastructure.Database
{
    public interface IDataManagement
    {
        #region Functions

        public void SaveData([Optional] [CanBeNull] string path);

        public void LoadData([Optional] [CanBeNull] string path);

        #endregion
    }
}