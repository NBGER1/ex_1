using System.Collections;

namespace Core
{
    public interface ICoroutineService
    {
        void RunCoroutine(IEnumerator coroutineBody);
    }
}