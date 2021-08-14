namespace GizmoLab.Infrastructure.Database
{
    public class LocalDataController : Database, ILocalDatabase
    {
        #region Consts

        private static readonly LocalDataController instance = new LocalDataController();

        #endregion

        #region Fields

        public static LocalDataController Instance
        {
            get { return instance; }
        }

        #endregion

        #region Functions

        private string _path;

        public void SetPath(string path)
        {
            _path = path;
        }

        public override void SaveData()
        {
        }

        public override void LoadData()
        {
        }

        #endregion

        #region Constructors

        private LocalDataController()
        {
        }

        #endregion
    }
}