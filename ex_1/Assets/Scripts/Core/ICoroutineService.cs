using System.Collections;
using UnityEngine;

namespace Core
{
    public interface ICoroutineService
    {
        #region Methods

        Coroutine RunCoroutine(IEnumerator coroutineBody);
        Awaiter WaitFor(float duration);

        #endregion
    }
}