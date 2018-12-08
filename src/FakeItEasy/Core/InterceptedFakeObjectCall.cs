namespace FakeItEasy.Core
{
    using System.Reflection;
    using FakeItEasy.Configuration;

    internal abstract class InterceptedFakeObjectCall : IInterceptedFakeObjectCall
    {
        /// <summary>
        /// Gets the arguments used in the call.
        /// </summary>
        public abstract ArgumentCollection Arguments { get; }

        /// <summary>
        /// Gets the faked object the call is performed on.
        /// </summary>
        public abstract object FakedObject { get; }

        /// <summary>
        /// Gets the method that's called.
        /// </summary>
        public abstract MethodInfo Method { get; }

        /// <summary>
        /// Freezes the call so that it can no longer be modified.
        /// </summary>
        /// <returns>A completed fake object call.</returns>
        public abstract CompletedFakeObjectCall AsReadOnly();

        /// <summary>
        /// Calls the base method, should not be used with interface types.
        /// </summary>
        public abstract void CallBaseMethod();

        /// <summary>
        /// Sets the specified value to the argument at the specified index.
        /// </summary>
        /// <param name="index">The index of the argument to set the value to.</param>
        /// <param name="value">The value to set to the argument.</param>
        public abstract void SetArgumentValue(int index, object value);

        /// <summary>
        /// Sets the return value of the call.
        /// </summary>
        /// <param name="returnValue">The return value.</param>
        public abstract void SetReturnValue(object returnValue);
    }
}
