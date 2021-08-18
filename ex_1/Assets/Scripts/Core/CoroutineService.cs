using System.Collections;
using UnityEngine;

namespace Core
{
    public class CoroutineService : MonoBehaviour, ICoroutineService
    {
        #region Methods

        /**
         * Starts a coroutine passed as argument 
         */
        public Coroutine RunCoroutine(IEnumerator coroutineBody)
        {
            return StartCoroutine(coroutineBody);
        }

        /**
         * Public Method waits x seconds before executing callback
         */
        public Awaiter WaitFor(float duration)
        {
            var awaiter = new Awaiter();
            RunCoroutine(WaitForInternal(duration, awaiter));
            return awaiter;
        }

        /*
         * Private method - Waits x seconds before executing callback
         */
        private IEnumerator WaitForInternal(float duration, Awaiter awaiter)
        {
            yield return null;
            yield return new WaitForSecondsRealtime(duration);
            awaiter.TriggerEnd();
        }

        #endregion
    }
}